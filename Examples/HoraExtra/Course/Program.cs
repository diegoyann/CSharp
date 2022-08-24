using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();
            Console.Write(" Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for( int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced? (y/n) ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'y' || resp == 'Y')
                {

                    Console.WriteLine("Additional charge: ");
                    int aditionalCharge = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hour:");
                    int hour = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    int valuePerHour = int.Parse(Console.ReadLine());

                    OutsourcedEmployee emp = new OutsourcedEmployee(aditionalCharge,name, hour, valuePerHour);
                    list.Add(emp);

                }
                else {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hour:");
                    int hour = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    int valuePerHour = int.Parse(Console.ReadLine());
                    Employee emp = new Employee(name, hour, valuePerHour);
                    list.Add(emp);

                }

            }
            
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }




        }
    }
}
