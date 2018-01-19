using Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappings
{
    public abstract class Repository<T, id> : IRepository<T, id>
    {
        public T Add(T objectToAdd)
        {      
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Save(objectToAdd);
                    session.Transaction.Commit();
                }
                    return objectToAdd;
            }
        }

        public void Delete(T objectToDelete)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Delete(objectToDelete);
                    session.Transaction.Commit();
                }
            }
        }

        public List<T> GetAll()
        {
            List<T> fetchedObjects = new List<T>();
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    fetchedObjects = session.Query<T>().ToList();
                    session.Transaction.Commit();
                }
            }
            return fetchedObjects;
        }

        public T GetById(id objectToGet)
        {
            T fetchedObject;
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    fetchedObject = session.Get<T>(objectToGet);
                    session.Transaction.Commit();
                }
            }
            return fetchedObject;
        }

        public T Update(T objectToUpdate)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Update(objectToUpdate);
                    session.Transaction.Commit();
                }
                
            }
            return objectToUpdate;
        }
    }
}
