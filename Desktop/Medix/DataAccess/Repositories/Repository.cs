using BaseLib;
using Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class Repository<T, id> : IRepository<T, id>
    {
        private IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork inUnitOfWork)
        {
            _unitOfWork = inUnitOfWork;
        }

        protected ISession Session { get { return _unitOfWork.Session; } }

        public IQueryable<T> FilterGetAll()
        {
            return Session.Query<T>();
        }

        public List<T> GetAll()
        {
            return Session.Query<T>().ToList();
        }

        public T Add(T objectToAdd)
        {
            Session.Save(objectToAdd);
            return objectToAdd;
        }

        public void Delete(int id)
        {
            Session.Delete(Session.Load<T>(id));
        }

        public void Delete(T objectToDelete)
        {
            Session.Delete(objectToDelete);
        }

        public T GetById(id objectToGet)
        {
            return Session.Get<T>(objectToGet);
        }

        public T Update(T objectToUpdate)
        {
            Session.BeginTransaction();
            Session.Update(objectToUpdate);
            Session.Transaction.Commit();
            return objectToUpdate;
        }
    }
}
