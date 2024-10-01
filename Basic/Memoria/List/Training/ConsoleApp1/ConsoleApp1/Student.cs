using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Grade { get; set; }


        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public void SchoolWork(int Work) => Grade = Grade + Work;

        public override string ToString()
        {
            return Id
                +", "
                +Name
                +", "
                +Grade.ToString();
        }
    }
}
