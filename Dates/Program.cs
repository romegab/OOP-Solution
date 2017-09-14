using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            DateModifier date = new DateModifier(firstDate, secondDate);
            Console.WriteLine(date.Difference);
        }
    }
}
