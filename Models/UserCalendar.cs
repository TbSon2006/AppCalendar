using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalendar.Models
{
    public class UserCalendar
    {
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public bool HasConflict(Appointment newAppt)
        {
            // Kiểm tra xem có lịch nào trùng khoảng thời gian không
            return Appointments.Any(a => newAppt.StartDay < a.EndDay && a.StartDay < newAppt.EndDay);
        }

        public void AddAppointment(Appointment appt) => Appointments.Add(appt);

        public bool FindMatch(string name, DateTime start)
        {
            // Giả lập logic tìm kiếm cuộc họp nhóm
            return name.ToLower().Contains("group");
        }
    }
}
