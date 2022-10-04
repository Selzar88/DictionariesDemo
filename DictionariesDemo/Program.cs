using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesDemo
{
    internal class Program
    {

        //key - value
        //Auto - car
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35,25),
                new Employee("HR", "Lora", 32,21),
                new Employee("Secretary", "Petra",28,18),
                new Employee("Lead Developer", " Artorias", 55,35),
                new Employee("Intern", "Ernest", 22,8),
            };

            Dictionary<int, string> mydictionary = new Dictionary<int, string>();
           Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();
            foreach(Employee emp in employees)
            {
                employeeDictionary.Add(emp.Role, emp);
            }


            for(int i = 0; i < employeeDictionary.Count; i++)
            {
                // usiong ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeeDictionary.ElementAt(i);
                //print the key
                Console.WriteLine("Key {0}, i is {1}", keyValuePair.Key, i);
                //storing value in an employee object
                Employee employeeValue = keyValuePair.Value;
                //printing the properties of the employee object
                Console.WriteLine("Employee Namer: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
            }

            string key = "CEO";
            if (employeeDictionary.ContainsKey(key))
            {
                Employee empl = employeeDictionary[key];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this Key {0}", key);
            }


            Employee result = null;
            //using TryGetValue() it returns true if the operation was successful and false otherwise
            if(employeeDictionary.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value Retrived!.");
                Console.WriteLine("Employee Namer: {0}",result.Name);
                Console.WriteLine("Employee Role: {0}", result.Role);
                Console.WriteLine("Employee Age: {0}", result.Age);
                Console.WriteLine("Employee Salary: {0}", result.Salary);
            }
            else
            {
                Console.WriteLine("The key does not exist");
            }


 
        }
    }

    class Employee
    {
        // few properites like Role,Name Age and Rate
        public string Role { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public float Rate { get; set; }
        //Yearly salary = rate/h * number if days * number of weeks * number if months

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        // simple constructor
        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }


    }
}
