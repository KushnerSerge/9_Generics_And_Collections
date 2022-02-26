using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Comparer_IEquality
{
    public class CompanyEqualityComparer : IEqualityComparer<CompanyPlus>
    {
        public bool Equals(CompanyPlus? x, CompanyPlus? y)
        {
            return x.Name == y.Name  && x.Rating == y.Rating;
        }

        public int GetHashCode([DisallowNull] CompanyPlus obj)
        {
            return (obj.Name + ";" + obj.Rating).GetHashCode();
        }
    }
}
