using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }
        public void AddingPersons(Person person)
        {
            this.members.Add(person);
        }
        public Person GetTheOldestMember()
        {
           return this.members.OrderByDescending(p => p.Age).FirstOrDefault();
            
        }

        public void printOlderThan30()
        {
            var greaterPersons = new List<Person>();

            foreach (var prs in this.members.OrderBy(x=> x.Name))
            {
                if (prs.Age>30)
                {
                    Console.WriteLine($"{prs.Name}->{prs.Age}");
                }
            }
        }
    }
}
