using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaAluno = 0;
            double c;
            double media = 0;

            for (c = 1; c < 10; c++)
            {
                do
                {
                    Console.WriteLine("---------------------------");
                    Console.Write("digita a " + c + " nota: ");
                    notaAluno = int.Parse(Console.ReadLine());

                    if (notaAluno < 0 || notaAluno > 10)
                    {
                        Console.WriteLine("Nota {0} invalida, Digite a {0}º:", c);
                    }
                } while (notaAluno < 0 || notaAluno > 10);
                media = media + notaAluno;
            }

            media = media / 10;

            Console.WriteLine("A média das notas é : " + media);
            Console.ReadKey();
        }
    }
}
