using System;
using Exercicio_Polimorfismo.Entities;
using System.Collections.Generic;
using System.Globalization;
namespace Exercicio_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            string name;
            int hours;
            double valuePerHour;

            System.Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                System.Console.Write($"Employee #{i} data");
                System.Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                name = Console.ReadLine();
                System.Console.Write("Hours: ");
                hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                if (op == 'y' || op == 'Y')
                {
                    System.Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours,valuePerHour, additionalCharge));
                } 
                else
                {
                    employees.Add(new Employee(name,hours,valuePerHour));
                }
            }
            Console.Clear();
            System.Console.WriteLine("PAYMENTS:");
            foreach(Employee obj in employees){
                System.Console.WriteLine(obj.Name + " - R$ " + obj.Payment().ToString("F2", CultureInfo.InstalledUICulture));
            }
        }
    }
}
