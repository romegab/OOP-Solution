using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < countOfMembers; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var name = input[0];
                var age = int.Parse(input[1]);

                var newPerson = new Person(name, age);
                family.AddingPersons(newPerson);
               
                  
                
            }
            var oldest = family.GetTheOldestMember();
            Console.WriteLine(oldest.Name+" "+oldest.Age);
            family.printOlderThan30();
        }
    }
}
