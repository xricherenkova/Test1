﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            Console.WriteLine(animal.GetNumberOfLegs(4));
        }
    }
}
