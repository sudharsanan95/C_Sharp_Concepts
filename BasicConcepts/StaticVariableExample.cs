using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan.BasicConcepts
{
    public class StaticVariableExample
    {
        public static int name = 0;
        int salary = 0;

        public void Display()
        {
            name += 2;
            salary += 2;
            Console.WriteLine("Name of the employee :"+name);
            Console.WriteLine("Salary of the employee :" + salary);

        }
    }
}
