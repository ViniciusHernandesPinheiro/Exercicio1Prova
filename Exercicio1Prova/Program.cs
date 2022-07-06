using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RA: 6322036
            //Nome: Vinícius Hernandes Pinheiro

            Console.WriteLine("Exercíco 1 ");

            Console.Write("\nDigite o seu nome: ");
            string nome;
            nome = Console.ReadLine();

            Console.Write("\nDigite a nota do trabalho: ");
            double NTrabalho;
            NTrabalho = double.Parse(Console.ReadLine());

            if (NTrabalho >= 0 && NTrabalho <= 10)
            {
                Console.Write("\nDigite a nota da 1° prova: ");
                double NProva1;
                NProva1 = double.Parse(Console.ReadLine());

                if (NProva1 >= 0 && NProva1 <= 10)
                {
                    Console.Write("\nDigite a nota da 2° prova: ");
                    double NProva2;
                    NProva2 = double.Parse(Console.ReadLine());

                    if (NProva2 >= 0 && NProva2 <= 10)
                    {
                        double media;
                        media = ((NTrabalho + NProva1 + NProva2) / 3);

                        if (media >= 8.5)
                        {
                            Console.WriteLine("\no aluno " + nome + " obteve conceito A na materia");
                        }

                        else if (media >= 7)
                        {
                            Console.WriteLine("\no aluno " + nome + " obteve conceito B na materia");
                        }

                        else if (media >= 6)
                        {
                            Console.WriteLine("\no aluno " + nome + " obteve conceito C na materia");
                        }

                        else if (media > 0)
                        {
                            Console.WriteLine("\no aluno " + nome + " obteve conceito D na materia");
                        }

                        else if (media == 0)
                        {
                            Console.WriteLine("\no aluno " + nome + " obteve conceito E na materia");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Digito invalido ");
                    }


                }

                else
                {
                    Console.WriteLine("Digito invalido ");
                }


            }

            else
            {
                Console.WriteLine("Digito invalido ");
            }

        }
    }
}
