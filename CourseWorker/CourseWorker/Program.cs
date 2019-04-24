using System;
using CourseWorker.Entities.Enums;
using CourseWorker.Entities;
using System.Globalization;

namespace CourseWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter department's name: ");
            string dpt = Console.ReadLine();
            Console.Write("Enter worker data: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());

            Departament departament = new Departament(dpt);
            Worker worker = new Worker(name, level, salary, departament);
            HourContract contract;


            Console.Write("How many contracts to this worker ? ");
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <=n; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = Double.Parse(Console.ReadLine());
                Console.Write("Duration (hours) :");
                int hour = int.Parse(Console.ReadLine());

                contract = new HourContract(date, valueperhour, hour);
                worker.addContract(contract);

            }

            Console.Write("Enter month and year to calculate income (MM/YYYY) ");
            string yearMonth = Console.ReadLine();
            int month = int.Parse(yearMonth.Substring(0, 2));
            int year = int.Parse(yearMonth.Substring(3));

            double sum = worker.Income(year, month);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + departament.Name);
            Console.WriteLine("Income for: " + yearMonth + " " + sum.ToString("F2", CultureInfo.InvariantCulture));


            

        }
    }
}
