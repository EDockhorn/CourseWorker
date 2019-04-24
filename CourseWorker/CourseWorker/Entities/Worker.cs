using System;
using System.Collections.Generic;
using System.Text;
using CourseWorker.Entities.Enums;

namespace CourseWorker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } = new WorkerLevel();
        public double baseSalary { get; set; }
        public Departament departament { get; set; } = new Departament();
        public List<HourContract> Contract = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament dpt)
        {
            Name = name;
            Level = level;
            this.baseSalary = baseSalary;
            departament = dpt;
        }

        public void addContract(HourContract contract)
        {
            Contract.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contract.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = baseSalary;
            foreach(HourContract contract in Contract)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
