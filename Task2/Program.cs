using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{

    class Departament
    {
        public string title;
        public int number;
        public string manager;
        public Departament(string title, int number, string manager)
        {
            this.title = title;
            this.number = number;
            this.manager = manager;
        }
    }
    class Employee
    {
        public string surname;
        public string name;
        public string patronymic;
        public Departament departament;
        public Employee(string surname, string name, string patronymic, Departament departament)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.departament = departament;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Departament departament1 = new Departament("Departament1", 1, "Manager1");
            Departament departament2 = new Departament("Departament2", 2, "Manager2");
            Departament departament3 = new Departament("Departament3", 3, "Manager3");

            List < Employee > everythingEmployees = new List<Employee>();

            everythingEmployees.Add(new Employee("Иванов", "Иван", "Иванович", departament1));
            everythingEmployees.Add(new Employee("Петров", "Петр", "Петрович", departament2));
            everythingEmployees.Add(new Employee("Сидоров", "Иван", "Петрович", departament3));
            everythingEmployees.Add(new Employee("Петров", "Иван", "Иванович", departament1));
            everythingEmployees.Add(new Employee("Иванов", "Петр", "Петрович", departament2));
            everythingEmployees.Add(new Employee("Петров", "Иван", "Петрович", departament3));

            Dictionary<string, List<Employee>> departamentEmploeyes = new Dictionary<string, List<Employee>>();

            departamentEmploeyes.Add(departament1.title, everythingEmployees.Where(el => el.departament.title.StartsWith(departament1.title)).ToList());
            departamentEmploeyes.Add(departament2.title, everythingEmployees.Where(el => el.departament.title.StartsWith(departament2.title)).ToList());
            departamentEmploeyes.Add(departament3.title, everythingEmployees.Where(el => el.departament.title.StartsWith(departament3.title)).ToList());

            foreach(KeyValuePair<string, List<Employee>> keyValue in departamentEmploeyes)
            {
                Console.WriteLine("Отдел " + keyValue.Key);
                Console.WriteLine(string.Join(Environment.NewLine, keyValue.Value.Select(x=> $"\t {x.surname} {x.name} {x.patronymic}")));
            }

        }
    }
}
