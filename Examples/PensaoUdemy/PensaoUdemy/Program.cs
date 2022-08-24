using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensaoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Cliente[] vect = new Cliente[10];

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #:" + i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Cliente(nome, email);

            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            for(int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
         
            
        }


        
    }
}
