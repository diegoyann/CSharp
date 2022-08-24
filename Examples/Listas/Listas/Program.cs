using System;
using System.Collections.Generic;


namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados serão registrados?");
            int n = int.Parse(Console.ReadLine());
            List < Empregados > list = new List<Empregados>();

            for (int i = 0; i < n; i++)
            {
                int j = i + 1;
                Console.WriteLine("Empregado número: " + j);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Empregados(id, nome, salario));
                Console.WriteLine();

            }

                Console.Write("Entre o empregado que tera o salario aumentado: ");
                int idEmpregado = int.Parse(Console.ReadLine());

                Empregados emp = list.Find(x => x.ID == idEmpregado);

                if(emp != null)
                {
                    Console.Write("Entre a porcentagem a ser adicionada: ");
                    int pctg = int.Parse(Console.ReadLine());
                    emp.AumentarSaiario(pctg);
                }

                else
                {
                    Console.WriteLine("Esse id não existe");
                }

                Console.WriteLine();
                Console.WriteLine("Lista atualizada de empregados");

                foreach (Empregados ob in list)
                {
                    Console.WriteLine(ob);
                }
            }
        }
    }

