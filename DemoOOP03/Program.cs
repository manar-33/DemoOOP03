using DemoOOP03.Binding;
using DemoOOP03.Polymorphism_overriding_;
using System.Diagnostics;

namespace DemoOOP03
{
    internal class Program
    {
        //public static void PorcessEmployee(Employee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmployeeData();
        //    }
        //}
        #region overloading
        //public static int SUM (int X, int Y)
        //    { 
        //    return X+Y;
        //     }
        //public static Double SUM(double X, double Y)
        //{
        //    return X + Y;
        //}
        //public static Double SUM(int X, double Y)
        //{
        //    return X + Y;
        //}
        //public static int SUM(int X, int Y, int Z)
        //{
        //    return X + Y + Z;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Polymorphism[overloading]
            // int Result = SUM (1, 2);
            // Console.WriteLine(Result);
            //  Result = SUM(1, 2 , 3);
            // Console.WriteLine(Result);
            //double Result02 = SUM(1.2, 2.2);
            // Console.WriteLine(Result02);
            #endregion
            #region Polymorphism[overriding]
            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeB(1,2);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.MyFun01();
            //typeB.MyFun02();
            #endregion
            #region Binding
            //TypeA refbase = new TypeB(1,2);
            //refbase.A = 10;
            ////refbase.B = 20;//invalid
            //refbase.MyFun01();
            //refbase.MyFun02();

            #endregion
            #region Not Binding
            //ref from child => object from parent
            // TypeB typeB = (TypeB)new TypeA(1);// casting
            #endregion
            #region Binding EX
            //FulltimeEmployee fulltimeemployee = new FulltimeEmployee(10, "Manar", 23 , 5000);
            //PorcessEmployee(fulltimeemployee);
            //PartTimeEmployee parttimeemployee = new PartTimeEmployee()
            //{
            //Id = 1,
            //Name = "Manar",
            //CountOfHours = 10,
            //Age = 23,
            //HourRate = 2.5M,
            
            //};
            //PorcessEmployee(parttimeemployee);
            #endregion
        }
    }
}
