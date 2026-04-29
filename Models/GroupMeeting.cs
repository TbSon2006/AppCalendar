using System;
using System.Collections.Generic;
using System.Text;

namespace AppCalendar.Models
{
    public class GroupMeeting : Appointment
    {
        public List<string> Participants { get; set; } = new List<string>();
        public void AddParticipant(string user) => Participants.Add(user);
    }
}
