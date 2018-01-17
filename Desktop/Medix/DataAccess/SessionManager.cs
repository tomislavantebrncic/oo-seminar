using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public sealed class SessionManager
    {
        private static ISessionFactory _sessionFactory;

        private static void OpenSession()
        {
            Configuration config = new Configuration();
            config.AddAssembly(Assembly.GetCallingAssembly());
            _sessionFactory = config.BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {
            if (_sessionFactory == null)
            {
                SessionManager.OpenSession();
            }

            return _sessionFactory.OpenSession();
        }

        public static void CloseSessionFactory()
        {
            if (_sessionFactory != null)
            {
                _sessionFactory.Close();
            }
        }
    }
}
