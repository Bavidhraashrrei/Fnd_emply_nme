using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnd_emply_nme
{
    class Program
    {
        static void Main(string[] args)
        {
            employeedetails em = new employeedetails();
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion");
            em.Add_employee_name();
            Console.WriteLine("Please enter the name of the employee to check promotion position");
            em.Find_Poistion();
            Console.ReadKey();
            }
    }
}
