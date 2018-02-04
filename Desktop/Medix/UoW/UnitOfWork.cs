using BaseLib;
using DataAccess.Mappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private static readonly ISessionFactory _sessionFactory;
        private ITransaction _transaction;

        public ISession Session { get; private set; }

        static UnitOfWork()
        {
            var fluentConfig = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString("Data Source=USER\\MSSQLSERVER01;Initial Catalog=MedixTest;Integrated Security=True")
                .ShowSql().FormatSql())
                .Mappings(m => m.FluentMappings.Add<EmployeeMap>())
                .Mappings(m => m.FluentMappings.Add<DoctorMap>())
                .Mappings(m => m.FluentMappings.Add<PatientMap>())
                .Mappings(m => m.FluentMappings.Add<WaitingRoomMap>())
                .Mappings(m => m.FluentMappings.Add<MedicalExaminationMap>())
                .Mappings(m => m.FluentMappings.Add<ExaminationTypeMap>())
                .Mappings(m => m.FluentMappings.Add<MedicalFindingMap>())
                .Mappings(m => m.FluentMappings.Add<NurseMap>())
                .Mappings(m => m.FluentMappings.Add<MedicalDiagnosisMap>())
                .Mappings(m => m.FluentMappings.Add<AddressMap>());

            var nhConfiguration = fluentConfig.BuildConfiguration();
            _sessionFactory = nhConfiguration.BuildSessionFactory();

            //var schemaExport = new SchemaExport(nhConfiguration);
            //schemaExport.Create(false, true);
        }

        public UnitOfWork()
        {
            Session = _sessionFactory.OpenSession();
        }

        public void BeginTransaction()
        {
            _transaction = Session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Commit();
            }
            catch
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();

                throw;
            }
            finally
            {
                Session.Dispose();
            }
        }

        public void Rollback()
        {
            try
            {
                if (_transaction != null && _transaction.IsActive)
                    _transaction.Rollback();
            }
            finally
            {
                Session.Dispose();
            }
        }
    }
}
