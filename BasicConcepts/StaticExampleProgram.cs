﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudharshanan.BasicConcepts
{
    public class StaticExampleProgram
    {
        public static void Main(string[] args)
        {
            StaticVariableExample ex = new StaticVariableExample();
            ex.Display();
            StaticVariableExample ex1 = new StaticVariableExample();
            ex1.Display();
            StaticVariableExample ex2 = new StaticVariableExample();
            ex2.Display();
        }
    }
}