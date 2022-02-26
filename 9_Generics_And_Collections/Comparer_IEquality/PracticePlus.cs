using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Comparer_IEquality
{
    public static class PracticePlus
    {
        public static void PracticEqualityComparer()
        {
            var company1 = new CompanyPlus("Company 1", 5);
            var company2 = new CompanyPlus("Company 1", 5);
           

            var stock = new Dictionary<CompanyPlus, string>(new CompanyEqualityComparer());
            stock.Add(company1, "+++");
            Console.WriteLine(stock.ContainsKey(company2));
        }
    }
}
