using DataAccess.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Model;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            var fluentConfig = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString("Data Source = USER\\MSSQLSERVER01; Initial Catalog = MedixTest; Integrated Security = True")
                .ShowSql().FormatSql())
                .Mappings(m => m.FluentMappings.Add<DoctorMap>())
                .Mappings(m => m.FluentMappings.Add<PatientMap>())
                .Mappings(m => m.FluentMappings.Add<WaitingRoomMap>())
                .Mappings(m => m.FluentMappings.Add<MedicalExaminationMap>())
                .Mappings(m => m.FluentMappings.Add<ExaminationTypeMap>())
                .Mappings(m => m.FluentMappings.Add<MedicalFindingMap>());

            var nhConfiguration = fluentConfig.BuildConfiguration();
            _sessionFactory = nhConfiguration.BuildSessionFactory();

            var schemaExport = new SchemaExport(nhConfiguration);
            schemaExport.Create(false, true);
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
