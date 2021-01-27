using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fnd_emply_nme
{
    public class employeedetails
    {
        List<string> emp_name = new List<string>();
        string name;
        public void Add_employee_name()
        {
            do
            {
                name = Console.ReadLine();
                emp_name.Add(name);
            } while (!string.IsNullOrEmpty(name));
        }
        public void Find_Poistion()
        {
            int index = 0;
            name = Console.ReadLine();
            index= emp_name.FindIndex(a => a.Contains(name));
            Console.WriteLine("{0} is the position {1} for promotion",name,index+1);

          }
    }
}
