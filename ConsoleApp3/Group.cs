using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Group
    {
        private static int ID;
        public string Room { get; set; }

        public string Name;
      

        private Student[] _students;

        public Group(string room,string name)
        {
            ID++;
            Room = room;
            Name = name;
            _students = new Student[0];

        }
        public void StudentAdd(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = student;
        }
        public void GetALLStudent()
        {
            foreach (var item in _students)
            {
                Console.WriteLine($"telebe haqqinda melumat:{item.Name} {item.Surname}:{item.Age} yaw-{item.Payment}AZN");
            }
        }
    }

   
}
