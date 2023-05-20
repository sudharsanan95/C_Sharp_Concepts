using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan
{
    public class BreakContinueExample
    {
        public void ContinueStatement()
        {
            // 1. for loop concept (when we know the iteration count, we can go for loop)
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;  // it is used to skip the particular statement
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------");
        }
        public void BreakStatement()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;  // it is used to perfom some irteations in a loop, once condition satisfied, iteration wont execute
                }
             
            }
            Console.WriteLine("--------------------------------");
        }

        public static void Main(string[] args)
        {
            BreakContinueExample ex = new BreakContinueExample();
            ex.ContinueStatement();
            ex.BreakStatement();
        }
    }
}
