using Model;
using Model.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DoctorRepository : IDoctorRepository
    {
        public Doctor GetDoctorWithIdAndPassword(string inId, string inPassword)
        {
            //Doctor d = new Doctor(1, "Tomislav Ante", "Brnčić", "0036486606", new DateTime(), "123456789", "lozinka");
            //return d;
            /*
            using (ISession nhibernateSession = SessionManager.GetCurrentSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                    "FROM Doctor WHERE employee_id = :username AND password = :password");
                query.SetString("username", inId);
                query.SetString("password", inPassword);

                IList<Doctor> foundDoctors = query.List<Doctor>();
                
                if (foundDoctors.Count == 0)
                {
                    return null;
                }
                else
                {
                    return foundDoctors[0];
                }
            }
            */
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                    {
                        IQuery query = session.CreateQuery(
                            "FROM Doctor");


                        IList<Doctor> foundDoctors = query.List<Doctor>();

                        if (foundDoctors.Count == 0)
                        {
                            return null;
                        }
                        else
                        {
                            return foundDoctors[0];
                        }
                }
            }
        }

    }
}
