using Delegates_Homework.Models;
using System;
using System.Collections.Generic;

namespace Delegates_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ShowPersonsThatGetsSalaryGreaterThan1000
            //Person person1 = new Person();
            //person1.Name = "Rasul";
            //person1.Surname = "Hasanov";
            //person1.Address = "Xalqlar";
            //person1.Salary = 1500;

            //Person person2 = new Person();
            //person2.Name = "Eli";
            //person2.Surname = "Veliyev";
            //person2.Address = "Ehmedli";
            //person2.Salary = 500;

            //Person person3 = new Person();
            //person3.Name = "Ruslan";
            //person3.Surname = "Eliyev";
            //person3.Address = "Ehmedli";
            //person3.Salary = 2500;

            //List<Person> people = new List<Person>();

            //people.Add(person1);
            //people.Add(person2);
            //people.Add(person3);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(ShowPerson(GetPerson, person));
            //}
            #endregion

            #region GetNizami'sBooksCount
            //Book book1 = new Book();
            //book1.Author = "Nizami";

            //Book book2 = new Book();
            //book2.Author = "Rasul";

            //Book book3 = new Book();
            //book3.Author = "Nizami";

            //List<Book> books = new List<Book>();

            //books.Add(book1);
            //books.Add(book2);
            //books.Add(book3);

            //Console.WriteLine(ShowBookCount(CheckBookAuthor, books));
            #endregion

            #region GetFilteredEmployeeMiddleSalary
            Employee emp1 = new Employee();
            emp1.Age = 37;
            emp1.Salary = 2600;

            Employee emp2 = new Employee();
            emp2.Age = 25;
            emp2.Salary = 3000;

            Employee emp3 = new Employee();
            emp3.Age = 15;
            emp3.Salary = 3600;


            List<Employee> employees = new List<Employee>();

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            Console.WriteLine(ShowEmployeeMiddleSalary(GetEmployeeMiddleSalary, employees));
            #endregion

        }

        #region ShowPersonsThatGetsSalaryGreaterThan1000
        public static bool GetPerson(Person person)
        {
            return person.Salary > 1000;
        }

        public static string ShowPerson(Predicate<Person> func, Person person)
        {
            if (func(person))
            {
                return $"{person.Name} {person.Surname} {person.Address}";
            }

            return null;
        }
        #endregion

        #region GetNizamis'sBooksCount
        public static bool CheckBookAuthor(Book book)
        {
            return book.Author == "Nizami";
        }

        public static int ShowBookCount(Predicate<Book> func, List<Book> book)
        {
            int count = 0;

            foreach (var item in book)
            {
                if (item.Author == "Nizami")
                {
                    count++;
                }
            }

            return count;
        }
        #endregion

        #region GetFilteredEmployeeMiddleSalary
        public static double GetEmployeeMiddleSalary(List<Employee> employees)
        {
            double salary = 0;
            double middleSalary = 0;
            int count = 0;

            foreach (var item in employees)
            {
                if (item.Age > 20 && item.Age < 40)
                {
                    count++;
                    salary += item.Salary;
                    middleSalary = salary / count;
                }
            }

            return middleSalary;
        }

        public static double ShowEmployeeMiddleSalary(Func<List<Employee>, double> func, List<Employee> employees)
        {
            return func(employees);
        }
        #endregion

    }
}