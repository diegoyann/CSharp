using System;


namespace ExercicioMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[,] matrix = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for ( int j = 0; j < c; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

           
            }
        }
    }

