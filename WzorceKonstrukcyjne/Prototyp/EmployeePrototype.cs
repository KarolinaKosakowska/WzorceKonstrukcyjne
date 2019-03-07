using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceKonstrukcyjne
{
    public class EmployeePrototype
    {
       public string Name;
        public string LastName;
        public int DailyHours = 8;
        public int Holidays = 26;
        public EmployeePrototype Clone()
        {
            return new EmployeePrototype
            {
                Name = Name,
                LastName = LastName,
                DailyHours = DailyHours,
                Holidays = Holidays
            };
        }
        public override string ToString()
        {
            return $"Name:{Name}, Last Name:{LastName},DailyHours:{DailyHours},Holidays:{Holidays}";
        }
    }
}
