using _9_Generics_And_Collections.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Repository
{

    public class RepositoryBase<T> : IRepositoryBase<T> 
    {
       public MyList<T> theList = new MyList<T>();
        public T[] FindAll() => theList.GetAllItems();
                    

        public T FindById(int id) => theList.GetItem(id);


        public void Create(T entity) => theList.Add(entity);

        public void Update(int index, T entity) => theList.Update(index, entity);

        public void Delete(int index) => theList.Delete(index);
    }

}
