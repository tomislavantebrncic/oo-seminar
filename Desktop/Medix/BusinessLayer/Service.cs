using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class Service<T, id> : IService<T, id>
    {
        public virtual IRepository<T, id> repository { get; set; }

        public Service() { }

        public Service(IRepository<T,id> inRepository) {
            repository = inRepository;
        }

        T IService<T, id>.GetById(id objectToGet)
        {
           return repository.GetById(objectToGet);
        }

        List<T> IService<T, id>.GetAll()
        {
            return repository.GetAll();
        }

        void IService<T, id>.Delete(T objectToDelete)
        {
            repository.Delete(objectToDelete);
        }

        T IService<T, id>.Add(T objectToAdd)
        {
            repository.Add(objectToAdd);
            return objectToAdd;
        }

        T IService<T, id>.Update(T objectToUpdate)
        {
            repository.Update(objectToUpdate);
            return objectToUpdate;
        }
    }
}
