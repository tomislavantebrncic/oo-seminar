using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbSessionFactory
    {
        ISessionFactory _sessionFactory = null;

        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {

                }
                return _sessionFactory;
            }
        }
    }
}
