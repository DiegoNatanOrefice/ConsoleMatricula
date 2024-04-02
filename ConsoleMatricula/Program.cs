using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatricula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vagasa = 5;
            int vagasd = 5;
            int vagase = 5;
            int vagasm = 5;
            int continuar = 1;
            while (continuar == 1)
            {

                Console.WriteLine("A - Administração | " + vagasa + " vagas");
                Console.WriteLine("D - Desenvolvimento de Sistemas | " + vagasd + " vagas");
                Console.WriteLine("E - Edificações | " + vagase + " vagas");
                Console.WriteLine("M - Mecatrônica | " + vagasm + " vagas\n");
                Console.Write("Escolha um curso para se matricular: ");
                string curso = Console.ReadLine().ToUpper();

                switch (curso)
                {
                    case "A":
                        if (vagasa >= 1)
                        {
                            Console.WriteLine("\nSeu cadastro foi realizado com sucesso!");
                            vagasa--;
                            Console.Write("Você deseja continuar?(1 - Sim | 0 - Não): ");
                            continuar = int.Parse(Console.ReadLine());
                        }
                        break;

                    case "D":
                        if (vagasd >= 1)
                        {
                            Console.WriteLine("\nSeu cadastro foi realizado com sucesso!");
                            vagasd--;
                            Console.Write("Você deseja continuar?(1 - Sim | 0 - Não): ");
                            continuar = int.Parse(Console.ReadLine());
                        }
                        break;

                    case "E":
                        if (vagase >= 1)
                        {
                            Console.WriteLine("\nSeu cadastro foi realizado com sucesso!");
                            vagase--;
                            Console.Write("Você deseja continuar?(1 - Sim | 0 - Não): ");
                            continuar = int.Parse(Console.ReadLine());
                        }
                        break;

                    case "M":
                        if (vagasm >= 1)
                        {
                            Console.WriteLine("\nSeu cadastro foi realizado com sucesso!");
                            vagasm--;
                            Console.Write("Você deseja continuar?(1 - Sim | 0 - Não): ");
                            continuar = int.Parse(Console.ReadLine());
                        }
                        break;

                    default:
                        Console.WriteLine("\nO caracter digitado não corresponde a nenhum curso");
                        Console.Write("Você deseja continuar?(1 - Sim | 0 - Não): ");
                        continuar = int.Parse(Console.ReadLine());
                        break;
                }
                Console.Clear();
            }
        }
    }
}
