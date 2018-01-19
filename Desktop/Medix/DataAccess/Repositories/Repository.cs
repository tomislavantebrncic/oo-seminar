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
                return (T)session.Save(objectToAdd);
            }
        }

        public void Delete(T objectToDelete)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                session.Delete(objectToDelete);
            }
        }

        public List<T> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<T>().ToList();
            }
        }

        public T GetById(id objectToGet)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Get<T>(objectToGet);
            }
        }

        public T Update(T objectToUpdate)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                session.Update(objectToUpdate);
                return objectToUpdate;
            }
        }
    }
}
