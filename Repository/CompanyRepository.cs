using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository() : base()
        {
        }
        public IEnumerable<Company> GetAllCompanies() =>
                     FindAll()
                    .OrderBy(c => c.Name)
                    .ToList();
    }
}
