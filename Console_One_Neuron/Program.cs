using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_One_Neuron
{
    class Program
    {
        public class Neuron
        {
            private decimal weight = 0.5m;
            public decimal ProcessInputData(decimal input)
            {
                return input * weight;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
