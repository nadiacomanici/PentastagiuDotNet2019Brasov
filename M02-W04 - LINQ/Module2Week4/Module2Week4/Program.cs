
using System.Collections.Generic;
using System.Linq;

namespace Module2Week4
{
    public class Program
    {
        static void Main()
        {
            var person1 = new Person { Name = "Marian Andrei", Age = 24, Position = Position.Dev };
            var person2 = new Person { Name = "Ioan Morar", Age = 29, Position = Position.Dev };
            var person3 = new Person { Name = "Ioan Ioan", Age = 29, Position = Position.Dev };

            List<Person> persons = new List<Person>()
            {
                person1,
                person2, 
                new Person { Name = "Andreea Popescu", Age = 39, Position = Position.Qa },
                new Person { Name = "Andrei Ilie", Age = 22, Position = Position.Dev },
                new Person { Name = "Maria Vasilescu", Age = 41, Position = Position.ProjectManager },
                new Person { Name = "Mircea Boeriu", Age = 27, Position = Position.Qa },
                new Person { Name = "George Tudor", Age = 32, Position = Position.Dev },
                new Person { Name = "Marian Ionescu", Age = 34, Position = Position.ProjectManager },
            };

            var list2 = persons.Where(x => x.Age > 30).ToList();

            var greaterThan30ListFromQuery = from x in persons
                                             where x.Age > 30
                                             select x;

            var sortedByAge = persons.OrderBy(x => x.Age).ThenBy(x => x.Name);
            var sortedByAgeThanByPosition = persons.OrderByDescending(x => x.Age).ThenBy(x => x.Position);

            List<string> getAllNames = persons.Select(x => x.Name).ToList();

            var pentalog = new Company() { Name = "Pentalog", Id = 1 };
            var personsAttachedToPentalog = persons.Select(x => new Employee { Name = x.Name, Age = x.Age, Position = x.Position, Company = pentalog }).ToList();

            /*List<Employee> list3 = new List<Employee>();

            foreach(Person item in persons)
            {
                var employee = new Employee
                {
                    Name = item.Name,
                    Age = item.Age,
                    Position = item.Position,
                    Company = pentalog
                };

                list3.Add(employee);
            }*/

            var skip2Take3 = persons.Skip(2).Take(3);

            Person theOnlyOneMircea = persons.Single(x => x.Name.Contains("Mircea"));
            Person theOnlyOneM = persons.SingleOrDefault(x => x.Name.Contains("sdfsdfsdfdsf"));

            var firstOrDefaultMarian2 = persons.First(x => x.Name.Contains("Marian"));
            var firstOrDefaultMarian = persons.FirstOrDefault(x => x.Name.Contains("Marian"));
            //var firstOrDefaultAna = persons.First(x => x.Name.Contains("Ana"));

            bool anyGreaterThan40 = persons.Any(x => x.Age > 40);
            bool allAreGreaterThan20 = persons.All(x => x.Age > 25);

            //if(!persons.All(x => x.Age > 25))
            //{
            //    throw new System.Exception("Nop! Sunt si mai mititei!");
            //}

            var exceptPerson1And2 = persons.Union(new List<Person> { person3 }).ToList();

            persons.AddRange(new List<Person> { person3 });

            double avarageAge = persons.Average(x => x.Age);
            double minAge = persons.Min(x => x.Age);

            var groupedByPosition = persons.GroupBy(
                p => p.Position, //key selector
                p => p.Name, //element selector
                (key, g) => new { Position = key, Persons = g.ToList() }); //result selector
        }
    }
}
