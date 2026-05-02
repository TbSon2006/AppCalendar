using AppCalendar.Models;

namespace AppCalendar
{
    public partial class CalendarUI : Form
    {
        private UserCalendar _calendar = new UserCalendar();
        private BindingSource _bindingSource = new BindingSource();
        public CalendarUI()
        {
            InitializeComponent();
            dgvSchedule.DataSource = _bindingSource;
        }
        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            using (var f = new AppointmentWindow())
            {
                f.SetDefaultDate(monthCalendar.SelectionStart);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    var appt = f.NewAppointment;
                    bool isGroup = f.IsGroupMeetingSelected;

                    // 1. Kiểm tra trùng lịch (Conflict Check)
                    if (_calendar.HasConflict(appt))
                    {
                        var result = MessageBox.Show("Thời gian này bị trùng! Bạn có muốn thay thế lịch cũ?",
                            "Cảnh báo trùng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.No) return; // Dừng lại (Reschedule)

                        // Logic thay thế (Replace)
                        _calendar.Appointments.RemoveAll(a => appt.StartDay < a.EndDay && a.StartDay < appt.EndDay);
                    }

                    // 2. Kiểm tra Group Meeting (Find Match)
                    /*if (_calendar.FindMatch(appt.Name, appt.StartDay))
                    {
                        var join = MessageBox.Show("Tìm thấy cuộc họp nhóm phù hợp. Bạn muốn tham gia vào nhóm này thay vì tạo lịch cá nhân?",
                            "Tham gia nhóm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (join == DialogResult.Yes)
                        {
                            // Giả lập join vào GroupMeeting
                            MessageBox.Show("Đã thêm bạn vào danh sách tham gia cuộc họp nhóm!");
                        }
                    }*/

                    if (isGroup)
                    {
                        // Thực hiện bước findMatchingGroupMeeting theo logic OOAD[cite: 1]
                        var match = _calendar.FindMatch(appt.Name, appt.StartDay);

                        if (match != null)
                        {
                            // askJoinGroupMeeting()
                            var join = MessageBox.Show("Tìm thấy cuộc họp nhóm tương ứng. Bạn muốn tham gia không?",
                                "Xác nhận nhóm", MessageBoxButtons.YesNo);

                            if (join == DialogResult.Yes)
                            {
                                _calendar.Appointments.Add(appt);
                                MessageBox.Show("Đã thêm bạn vào danh sách tham gia nhóm!");
                                RefreshGrid();
                                return; // Kết thúc luồng, không lưu thành lịch cá nhân
                            }
                        }
                    }

                    // 3. Lưu và Refresh
                    _calendar.Appointments.Add(appt);
                    RefreshGrid();
                }
            }
        }

        private void RefreshGrid()
        {
            _bindingSource.DataSource = null;
            _bindingSource.DataSource = _calendar.Appointments;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Theo đúng Sequence Diagram, refresh sẽ cập nhật lại view
            RefreshGrid();
            MessageBox.Show("Đã cập nhật danh sách lịch!", "Thông báo");
        }

        private void FilterAppointmentsByDate()
        {
            DateTime selectedDate = monthCalendar.SelectionStart.Date;

            // Lọc danh sách chỉ lấy những cuộc hẹn trong ngày được chọn[cite: 9]
            var filteredList = _calendar.Appointments
            .Where(a => a.StartDay.Date == selectedDate)
            .ToList();

            _bindingSource.DataSource = null;
            _bindingSource.DataSource = filteredList;
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            FilterAppointmentsByDate();
        }

        private void CalendarUI_Load(object sender, EventArgs e)
        {

        }
    }
}
