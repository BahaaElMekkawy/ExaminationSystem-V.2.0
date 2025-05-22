using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExaminationSystem.Users.Interfaces;

namespace ExaminationSystem.Users.Classes
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Role: {Role}";
        }
    }
}
