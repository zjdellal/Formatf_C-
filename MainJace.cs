using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jace;

namespace F1
{
    class MainJace
    {
        public static void Main(string[] args)
        {
            CalculationEngine calculEngine = new CalculationEngine();
            Console.WriteLine("Entrz un formule math");
            String formule = Console.ReadLine();
            Console.WriteLine(calculEngine.Calculate(formule));
            Console.ReadLine();
        }

    }
}