using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentApp.Data
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? PersonalHealthNumber { get; set; }
        public List<Role>? UserRoles { get; set; }
    }
}
