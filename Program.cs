using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_cs
{
    internal class Program
    {
        enum operacoes { Adição = 1, Subtração, Multiplicação, Divisão }
        static void Main(string[] args)
        {
            // EX 1 - calculator in cmd
            Console.WriteLine("Qual operação você deseja fazer?");
            Console.WriteLine(" 1- Adição \n 2- Subtração \n 3-Multiplicação \n 4- Divisão");
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            int add = num1 + num2;
            int sub = num1 - num2;
            int mult = num1 * num2;
            int div = num1 / num2;

            if (choice == 1)
            {
                Console.WriteLine(add);
            }
            else if (choice == 2)
            {
                Console.WriteLine(sub);

            }
            else if (choice == 3)
            {
                Console.WriteLine(mult);
            }
            else if (choice == 4)
            {
                Console.WriteLine(div);
            }
            else
            {
                Console.WriteLine("Você não escolheu nenhuma das opções acima");
            }
            Console.ReadLine();
        }
    }
}
