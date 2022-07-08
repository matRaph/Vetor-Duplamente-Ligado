using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDuplamenteLigado
{
    internal class RankForaDeAlcanceException : Exception
    {
        public RankForaDeAlcanceException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
