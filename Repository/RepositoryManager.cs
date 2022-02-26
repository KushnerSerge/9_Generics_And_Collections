using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public sealed class RepositoryManager : IRepositoryManager
	{

		ICompanyRepository _companyRepository;
		IEmployeeRepository _employeeRepository;

		public RepositoryManager()
		{
			_companyRepository =  new CompanyRepository();
			_employeeRepository = new EmployeeRepository();
		}

		public ICompanyRepository Company => _companyRepository;
		public IEmployeeRepository Employee => _employeeRepository;

		
	}
}
