﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDuplamenteLigado
{
    internal class InsercaoForaDeAlcanceException : Exception
    {
        public InsercaoForaDeAlcanceException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
