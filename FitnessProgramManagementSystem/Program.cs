using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgram FitnessProgram1 = new FitnessProgram("FIT_001", "YOGA", "3 months","10");
            Console.WriteLine(FitnessProgram1.ToString());
            Console.ReadLine();
        }
    }
}
