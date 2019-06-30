using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
   class Program
    { 
        static void Main(string[] args)
        {
           
            GroupType developer = new GroupType("Developer Group",3000);
            Group group = new Group("P111", "Venus");
            Student student = new Student("Aynur", "Dv", 45, 4566, "aynur@gmail.com");
            group.StudentAdd(student);
           
            group.GetALLStudent();
        }


    }
  
}

