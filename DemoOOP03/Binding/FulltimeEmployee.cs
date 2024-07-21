using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Binding
{
    internal class FulltimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public FulltimeEmployee( int id , string name , int age ,decimal salary)
        {
            Id = id ;
            Name = name ;
            Age = age ;
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Full Time Employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($" Full Time Employee : Id : {Id}, Name : {Name}, Age : {Age} , Salary : {Salary}");
        }
    }
}
