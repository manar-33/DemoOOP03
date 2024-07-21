using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP03.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }
        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        public override void GetEmployeeData()
        {
            Console.WriteLine($" Part Time Employee : Id : {Id}, Name : {Name}, Age : {Age} , CountOfHours : {CountOfHours} , HourRate {HourRate}");
        }
    }
}
