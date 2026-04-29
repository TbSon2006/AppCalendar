using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalendar.Models
{
    public class Appointment
    {
        public string Name { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public string Location { get; set; }
        public long GetDuration() => (long)(EndDay - StartDay).TotalMinutes;
    }
}
