using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Employee to Employee Wage Program");
            //    PresentEmp emp = new PresentEmp(1);
            //    emp.CheckEmp();


            //DailyEmployee c = new DailyEmployee(2,1);

            //c.EmployeeDaily();

            //SwitchEm ram = new SwitchEm(20,2);
            //    SwitchEm dev = new SwitchEm(10, 4);
           //    SwitchEm shree = new SwitchEm(15, 6);

            //ram.EmpSwitch();
            //dev.EmpSwitch();
            //shree.EmpSwitch();

            // Month employee
           // MonthEmplo ram = new MonthEmplo(10, 4,6);
           // MonthEmplo dev = new MonthEmplo(20, 6,7);
           // MonthEmplo shree = new MonthEmplo(30, 8,8);

           // ram.EmoploMonth();
           //dev .EmoploMonth();
           //shree .EmoploMonth();

            //Hourse Employee


            HourseEmp ram = new HourseEmp("Accnture", 20, 2, 10);
            HourseEmp dev = new HourseEmp("Mindtree", 10, 4, 20);
            HourseEmp shree = new HourseEmp("Cognizant", 15, 6, 30);

            ram.EmpHourse();
            dev.EmpHourse();
            shree.EmpHourse();
        }
    }
}
