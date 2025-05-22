using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Users.Classes
{
    public class Student : User
    {
        HashSet<int> enrolledCourses = new HashSet<int>(); // Subject Ids the student is enrolled in
        public Student(string name , int id )
        {
            Name = name;
            Id = id;
            Role = "Student";
        }

        public void EnrollInSubject(int subid) 
        {
            enrolledCourses.Add(subid);
        }

        public bool IsEnrolledInSubject(int subid)
        {
            return enrolledCourses.Contains(subid);
        }
    }
}
