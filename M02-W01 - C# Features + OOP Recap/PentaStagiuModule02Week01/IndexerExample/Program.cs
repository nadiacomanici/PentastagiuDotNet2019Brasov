using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

    class EmployeeCollection
    {
        int length;
        Employee[] array;

        public EmployeeCollection(int length)
        {
            this.length = length;
            array = new Employee[length];
        }

        public Employee this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public Employee this[string name]
        {
            get
            {
                foreach(Employee e in array)
                {
                    if(e.Name == name)
                    {
                        return e;
                    }
                }
                return null;
            }
        }

        public Employee this[string name, int age]
        {
            get
            {
                foreach (Employee e in array)
                {
                    if (e.Name == name && e.Age == age)
                    {
                        return e;
                    }
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmployeeCollection collection = new EmployeeCollection(3);
            collection[0] = new Employee("Gigel", 30, 10);
            collection[1] = new Employee("Cornel", 32, 15);
            collection[2] = new Employee("Fănel", 35, 20);

            Console.WriteLine(collection[1].Name);
            Console.WriteLine(collection["Gigel"].Salary);
            Console.WriteLine(collection["Cornel", 32].Salary);
        }
    }
}
