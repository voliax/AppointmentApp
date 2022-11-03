using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentApp.Data
{
    public class Appointment
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime TimeLength { get; set; }

        public Doctor AppointmentDoctor { get; set; }
    }
}
