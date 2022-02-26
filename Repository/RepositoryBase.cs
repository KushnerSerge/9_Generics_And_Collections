using _9_Generics_And_Collections;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        MyList<T> objectList = new MyList<T>();

        public T[] FindAll() =>
            objectList.GetAllItems();

        public T Find(int i) => objectList.GetItem(i);


        public void Create(T entity) => objectList.Add(entity);

        public void Update(int index, T entity) => objectList.Update(index, entity);

        public void Delete(int index) => objectList.Delete(index);
    }
}
