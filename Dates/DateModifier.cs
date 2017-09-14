using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class DateModifier
    {
        private string firstDate;
        private string secondDate;
        private int difference;
        public int Difference { get { return this.difference; } }


        public DateModifier(string firstDate,string secondDate)
        {
            this.firstDate = firstDate;
            this.secondDate = secondDate;
            List<string> separetedFirst = new List<string>();
            List<string> separetedSecond = new List<string>();
            separetedFirst = this.firstDate.Split().ToList();
            separetedSecond = this.secondDate.Split().ToList();
            int firstDays = 0;
             firstDays+=int.Parse(separetedFirst[0])*365+int.Parse(separetedFirst[1])*60+int.Parse(separetedFirst[2]);
            int secondDays = 0;
            secondDays+= int.Parse(separetedSecond[0]) * 365 + int.Parse(separetedSecond[1]) * 60 + int.Parse(separetedSecond[2]);
            int difference = secondDays - firstDays;
            this.difference = difference;

        }

    }
}
