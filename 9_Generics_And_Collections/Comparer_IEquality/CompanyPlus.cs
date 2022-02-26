using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Comparer_IEquality
{
    public class CompanyPlus
    {
        public string Name { get; set; }
        public int Rating { get; set; }

        public CompanyPlus(string name, int rating)
        {
            Name = name;
            Rating = rating;
        }
    }
}
