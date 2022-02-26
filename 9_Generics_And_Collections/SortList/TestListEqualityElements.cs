using _9_Generics_And_Collections.Comparer_IEquality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.SortList
{
    public class TestListEqualityElements
    {
        public static void TestingSortingList()
        {
            var companyList = new List<CompanyPlus>()
            {
                  new CompanyPlus("Company 1", 4),
                  new CompanyPlus("Company 1", 5),
                  new CompanyPlus("Company 3", 1),
                  new CompanyPlus("Company 4", 2)
            };
            companyList.Sort(new RatingComparer());
            foreach(var company in companyList)
            {
                Console.WriteLine(company.Rating);
            }
        }

    }

}

