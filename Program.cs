using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkFourRearrangementOfValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fistName = "Петров";
            string lastName = "Олег";

            Console.WriteLine($"{fistName} {lastName}");

            string transitVariable = fistName;

            fistName = lastName;
            lastName = transitVariable;

            Console.WriteLine($"{fistName} {lastName}");
        }
    }
}
