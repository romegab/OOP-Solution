using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            Employee employee;
            for (int i = 0; i < count; i++)
            {
                var separetedItems = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (separetedItems.Count>4)
                {
                    if (int.TryParse(separetedItems[4],out int age))
                    {
                        employee = new Employee(separetedItems[0], decimal.Parse(separetedItems[1]), separetedItems[2], separetedItems[3],int.Parse(separetedItems[4]));
                    }
                    else if (separetedItems.Count==4)
                    {
                        employee = new Employee(separetedItems[0], decimal.Parse(separetedItems[1]), separetedItems[2], separetedItems[3], (separetedItems[4]));
                    }
                    else if (separetedItems.Count==5 && int.TryParse(separetedItems[4], out age))
                    {
                        employee = new Employee(separetedItems[0], decimal.Parse(separetedItems[1]), separetedItems[2], separetedItems[3], separetedItems[5],int.Parse(separetedItems[4]));

                    }
                    else if(separetedItems.Count == 5 && int.TryParse(separetedItems[5], out age))
                    {
                        employee = new Employee(separetedItems[0], decimal.Parse(separetedItems[1]), separetedItems[2], separetedItems[3], separetedItems[4], int.Parse(separetedItems[5]));

                    }
                }
                 

            }
        }
    }
}
