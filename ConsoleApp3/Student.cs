using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Student
    {
        private static int ID;
        public string Name;
        public string Surname;
        public byte Age;
        public float Payment { get; set; }
       
        private string Email { get; set; }
        
        public  Student(string name , string surname ,byte age,float payment, string email)
        {
            ID++;
            Name = name;
            Surname = surname;
            Age = age;
            Payment = payment;
            Email = email;
        }
    }
}
