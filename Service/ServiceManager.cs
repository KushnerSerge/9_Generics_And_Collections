using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public sealed class ServiceManager : IServiceManager
	{
		ICompanyService _companyService;
		IEmployeeService _employeeService;

		public ServiceManager(IRepositoryManager repositoryManager)
		{
			_companyService = new CompanyService(repositoryManager);
			_employeeService = new EmployeeService(repositoryManager);
		}

		public ICompanyService CompanyService => _companyService;
		public IEmployeeService EmployeeService => _employeeService;
	}

}
