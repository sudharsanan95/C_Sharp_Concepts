using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan
{
    public class LoopsConcept
    {
        public void ForLoop()
        {
            // 1. for loop concept (when we know the iteration count, we can go for loop)
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;  //( when we want some less iterations, there we can use break statement)
                }
            }
            Console.WriteLine("--------------------------------");
        }
        public void WhileLoop() // when we dont know the iteration count
        {
            int i = 10;
            while (i>1)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("--------------------------------");
        }
        public void DoWhileLoop() // it will print the statement fpr one time without checking the condition
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i > 10);

        }
        public static void ForEach()
        {
            string[] arr = new string[5];
            arr[0] = "my"; arr[1] = "name"; arr[2] = "is"; arr[3] = "sudharsanan";
             foreach(var a in arr)
            {

                //Console.WriteLine(a);
                if (arr[0] !="sudharsanan") 
                {
                    Console.WriteLine("its incorrect");
                    break;
                }
               
            }
        }

        public static void Main(string[] args)
        {
            LoopsConcept loops = new LoopsConcept();
            loops.ForLoop();
            loops.WhileLoop();
            loops.DoWhileLoop();
            ForEach();
        }
    }
}
