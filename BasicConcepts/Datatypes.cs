using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan
{
    public class Datatypes
    {
        public void Additionvar()
        {
            var a = 8; var b = 9;
            var c = a + b;
            Console.WriteLine("var data type example : "+c);
        }

        public void Additionint(int a,int b) 
        {
            int c = a + b;
            Console.WriteLine("int data type example :"+c);
        }
        public void Additionfloat(float a, float b)
        {
            float c = a + b;
            Console.WriteLine("float data type example :" + c);
        }
        public void Additiondouble(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("double data type example :" + c);
        }
        public void Additionchar()
        {
            char input = 'a';
            Console.WriteLine("char data type example :" +input);
        }
        public void Additionstring()
        {
            string input = "what are you doing?";
            Console.WriteLine("string data type example :" + input);
        }
        public static void Main(string[] args)
        {
            Datatypes data = new Datatypes();
            data.Additionvar();
            data.Additionint(8, 6);
            data.Additionfloat(10.785f, 8.245f);
            data.Additiondouble(16, 13);
            data.Additionchar();
            data.Additionstring();
            
        }
        
    }
}
