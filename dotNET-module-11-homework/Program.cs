using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace dotNET_module_11_homework
{
    class Program
    {
        static void ex1()
        {
            Console.Write("Введите количество сотрудников: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[numberOfEmployees];

            // Заполнение массива сотрудников данными пользователя
            for (int i = 0; i < numberOfEmployees; i++)
            {
                employees[i] = new Employee();
                Console.WriteLine($"Введите информацию о сотруднике №{i + 1}:");
                Console.Write("ФИО: ");
                employees[i].FullName = Console.ReadLine();
                Console.Write("Дата приема на работу (гггг-мм-дд): ");
                employees[i].HireDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Должность: ");
                employees[i].Position = Console.ReadLine();
                Console.Write("Зарплата: ");
                employees[i].Salary = decimal.Parse(Console.ReadLine());
                Console.Write("Пол (м/ж): ");
                employees[i].Gender = Console.ReadLine();
            }

            // a. Вывод полной информации обо всех сотрудниках
            Console.WriteLine("\nПолная информация о всех сотрудниках:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

            // b. Вывод информации о сотрудниках выбранной должности
            Console.Write("\nВведите должность для поиска сотрудников: ");
            string chosenPosition = Console.ReadLine();
            Console.WriteLine($"\nСотрудники на должности '{chosenPosition}':");
            foreach (var employee in employees.Where(emp => emp.Position.Equals(chosenPosition)))
            {
                Console.WriteLine(employee.ToString());
            }

            // c. Поиск менеджеров с зарплатой выше средней зарплаты клерков
            decimal averageClerkSalary = employees.Where(emp => emp.Position.Equals("Clerk")).Average(emp => emp.Salary);
            var managersAboveAverageClerkSalary = employees
                .Where(emp => emp.Position.Equals("Manager") && emp.Salary > averageClerkSalary)
                .OrderBy(emp => emp.FullName);

            Console.WriteLine("\nМенеджеры с зарплатой выше средней зарплаты клерков:");
            foreach (var manager in managersAboveAverageClerkSalary)
            {
                Console.WriteLine(manager.ToString());
            }

            // d. Информация о сотрудниках, принятых на работу позже определенной даты
            Console.Write("\nВведите дату для поиска сотрудников (гггг-мм-дд): ");
            DateTime specifiedDate = DateTime.Parse(Console.ReadLine());
            var employeesAfterDate = employees
                .Where(emp => emp.HireDate > specifiedDate)
                .OrderBy(emp => emp.FullName);

            Console.WriteLine("\nИнформация о сотрудниках, принятых на работу после указанной даты:");
            foreach (var employee in employeesAfterDate)
            {
                Console.WriteLine(employee.ToString());
            }

            // e. Информация о сотрудниках в зависимости от пола
            Console.Write("\nВведите пол для поиска (м/ж, или любой другой символ для вывода всех): ");
            string chosenGender = Console.ReadLine();
            if (chosenGender.Equals("м", StringComparison.OrdinalIgnoreCase))
            {
                var maleEmployees = employees.Where(emp => emp.Gender.Equals("м", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("\nИнформация о мужчинах:");
                foreach (var employee in maleEmployees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            else if (chosenGender.Equals("ж", StringComparison.OrdinalIgnoreCase))
            {
                var femaleEmployees = employees.Where(emp => emp.Gender.Equals("ж", StringComparison.OrdinalIgnoreCase));
                Console.WriteLine("\nИнформация о женщинах:");
                foreach (var employee in femaleEmployees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            else
            {
                Console.WriteLine("\nИнформация о всех сотрудниках:");
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            ex1();
        }
    }
}
