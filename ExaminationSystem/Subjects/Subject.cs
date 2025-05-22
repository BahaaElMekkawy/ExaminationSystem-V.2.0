using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.Subjects
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsStarted { get; private set; } = false;

        public Subject(string name, int id)
        {
            Id = id;
            Name = name;
        }
        public void StartExam()
        {
            if (IsStarted)
            {
                Console.WriteLine("Exam already started");
                return;
            }
            IsStarted = true;
            Console.WriteLine($"Exam for {Name} started");
        }
        public void StopExam()
        {
            if (!IsStarted)
            {
                Console.WriteLine("Exam not started yet");
                return;
            }
            IsStarted = false;
            Console.WriteLine($"Exam for {Name} stopped");
        }

    }
}
