using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{

    class Departament
    {
        public string Title;
        public int Number;
        public string Manager;
        public Departament(string title, int number, string manager)
        {
            this.Title = title;
            this.Number = number;
            this.Manager = manager;
        }
    }
    class Employee
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public Departament Departament;
        public Employee(string surname, string name, string patronymic, Departament departament)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Departament = departament;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Departament departament1 = new Departament("Departament1", 1, "Manager1");
            Departament departament2 = new Departament("Departament2", 2, "Manager2");
            Departament departament3 = new Departament("Departament3", 3, "Manager3");

            List < Employee > everythingEmployees = new List<Employee> 
            {
                new Employee("Иванов", "Иван", "Иванович", departament1),
                new Employee("Петров", "Петр", "Петрович", departament2),
                new Employee("Сидоров", "Иван", "Петрович", departament3),
                new Employee("Петров", "Иван", "Иванович", departament1),
                new Employee("Иванов", "Петр", "Петрович", departament2),
                new Employee("Петров", "Иван", "Петрович", departament3),
            };


            var departamentEmploeyes = everythingEmployees.GroupBy(x => x.Departament.Title).ToDictionary(x => x.Key);

            foreach(var el in departamentEmploeyes)
            {
                Console.WriteLine(el.Key);
                foreach(var elInList in el.Value)
                {
                    Console.WriteLine($"\t {elInList.Surname} {elInList.Name} {elInList.Patronymic}");
                }
            }
        }
    }
}
