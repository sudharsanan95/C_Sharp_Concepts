using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan.BasicConcepts
{
    public class Constructorexample
    {
        public Constructorexample() // constructor will execute first b4 all methods in a class
        {
            Console.WriteLine("india");
        }
        public void Name()
        {
            Console.WriteLine("sudharshan");
        }
        public void College()
        {
            Console.WriteLine("sathyabama");
        }
        public void MaraitalStatus()
        {
            Console.WriteLine("married");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("I am Engineering Graduate");
            Constructorexample cons = new Constructorexample();
            cons.Name();
            cons.College();
            cons.MaraitalStatus();
            
        }
        
    }

}
