using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorDuplamenteLigado
{
    internal class VetorVazioException : Exception
    {
        public VetorVazioException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
