using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Contracts
{
	public interface IRepositoryBase<T>
	{
		T[] FindAll();
		T FindById(int id);
		void Create(T entity);
		void Update(int index,T entity);
		void Delete(int index);
	}
}
