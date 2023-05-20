using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan
{
    internal class SwitchCaseExample
    {
        public void Switch()
        {
            var input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        Console.WriteLine("you are from India");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("you are from China");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("you are from Japan");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("you are from Germany");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("you are not eligible to apply");
                        break;
                    }
            }

        }
        public static void Main(string[] args)
        {
            SwitchCaseExample example = new SwitchCaseExample();
            example.Switch();
        }
    }
}
