using AppCalendar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCalendar
{
    public partial class AppointmentWindow : Form
    {
        public Appointment NewAppointment;
        public bool IsGroupMeetingSelected { get; private set; }
        public AppointmentWindow()
        {
            InitializeComponent();
            // Thiết lập định dạng ngày giờ cho đẹp
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void AppointmentWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thực hiện validateInput() theo Sequence Diagram
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên cuộc hẹn không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpEnd.Value <= dtpStart.Value)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsGroupMeetingSelected = chkIsGroupMeeting.Checked;

            // Tạo object mới
            NewAppointment = new Appointment
            {
                Name = txtName.Text,
                Location = txtLocation.Text,
                StartDay = dtpStart.Value,
                EndDay = dtpEnd.Value
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void SetDefaultDate(DateTime selectedDate)
        {
            // Đặt ngày bắt đầu và kết thúc theo ngày đã chọn trên lịch tháng[cite: 8]
            dtpStart.Value = selectedDate.Date.AddHours(DateTime.Now.Hour);
            dtpEnd.Value = dtpStart.Value.AddHours(1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
