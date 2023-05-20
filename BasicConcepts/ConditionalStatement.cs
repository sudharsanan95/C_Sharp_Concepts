using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan
{
    public class ConditionalStatement
    {
        public void Check()
        {
            var input = Console.ReadLine();
            var pass = "appu1234";

            if (input == pass)
            {
                Console.WriteLine("Loggin Successfull");
            }
            else
            {
                Console.WriteLine("Invalid passowrd");
            }
        }
        public static void Main(string[] args)
        {
            ConditionalStatement condition = new ConditionalStatement();
            condition.Check();

        }
    }
}


   


