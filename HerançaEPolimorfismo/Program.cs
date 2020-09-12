using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerançaEPolimorfismo.Entities

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data");
                Console.Write("Outsourced (y/n)? ");
                char outsourceCheck = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee emp = new Employee(name, hours, valuePerHour);

                if (outsourceCheck == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee outsourced = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    list.Add(outsourced);
                }
                else
                {
                    list.Add(emp);
                }

                

            }


            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj.Name + " - "
                    + " $ " + obj.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}


