using AppointmentApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentApp.Data
{
    public class Role
    {
        public int Id { get; set; }
        public Roles Type { get; set; }
    }
}
