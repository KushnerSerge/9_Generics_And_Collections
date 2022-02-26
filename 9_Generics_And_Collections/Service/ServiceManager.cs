using _9_Generics_And_Collections.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Service
{
    public class ServiceManager<T>
    {
        public RepositoryBase<T> _repositoryBase = new RepositoryBase<T>();

       public ServiceManager(RepositoryBase<T> repositoryBase)
        {
           // _repositoryBase = repositoryBase;
        }
  
        public ServiceManager() { }

        public T[] GetAllItmes()
        {
          return  _repositoryBase.FindAll();
        }
        
        public T GetItemById(int id)
        {
            return _repositoryBase.FindById(id);
        }

        public void CreateItem(T entity )
        {
            _repositoryBase.Create(entity);
        }

        public void UpdateItem(int index, T entity)
        {
            _repositoryBase.Update(index, entity);
        }
        public void DeleteItem(int index)
        {
            _repositoryBase.Delete(index);

        }
    }
}
