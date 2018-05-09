using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string oper;
            ToInt values = new ToInt();

            Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
            oper = Console.ReadLine();

            values.Identify(oper);

        }
    }
}
