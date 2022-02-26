using _9_Generics_And_Collections.Entities;
using _9_Generics_And_Collections.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections.Presentation
{
    public class LikeController<T>
    {
        public ServiceManager<T> serviceManager = new ServiceManager<T>();

        public T[] GET_All_Items() => serviceManager.GetAllItmes();
        public T GET_Ttem_By_Id(int id )=> serviceManager.GetItemById(id);
        public void POST(T entity) => serviceManager.CreateItem(entity);
        public void UPDATE(int index, T entity) => serviceManager.UpdateItem(index, entity);
        public void DELETE(int index) => serviceManager.DeleteItem(index);  


    }
}
