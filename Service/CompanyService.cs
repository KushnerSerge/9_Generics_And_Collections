using Contracts;
using Entities.Models;
using Service.Contracts;
using System.Collections;

namespace Service
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager _repository;

        public CompanyService(IRepositoryManager repository)
        {
            _repository = repository;

        }
        public IEnumerable<Company> GetAllCompanies()
        {

            ICompanyRepository companyRep = _repository.Company;
           var result = companyRep.GetAllCompanies();

            return new List<Company>();
        }
    }
}