using _9_Generics_And_Collections.Comparer_IEquality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.SortList
{
    public class RatingComparer : Comparer<CompanyPlus>
    {
        public override int Compare(CompanyPlus? x, CompanyPlus? y)
        {
           if(Equals(x,y))
            {
                return 0;
            }
           return x.Rating.CompareTo(y.Rating);
        }
    }
}
