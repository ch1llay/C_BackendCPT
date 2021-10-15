using System;
using System.Collections.Generic;

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

            List<Employee> departament1Emloeyees = new List<Employee>();
            List<Employee> departament2Emloeyees = new List<Employee>();
            List<Employee> departament3Emloeyees = new List<Employee>();

            foreach(var employee in everythingEmployees)
            {
                switch (employee.departament.title)
                {
                    case "Departament1":
                        departament1Emloeyees.Add(employee);
                        break;
                    case "Departament2":
                        departament2Emloeyees.Add(employee);
                        break;
                    case "Departament3":
                        departament3Emloeyees.Add(employee);
                        break;

                }
            }
            departamentEmploeyes.Add("Departament1", departament1Emloeyees);
            departamentEmploeyes.Add("Departament2", departament2Emloeyees);
            departamentEmploeyes.Add("Departament3", departament3Emloeyees);




        }
    }
}
