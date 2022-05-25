using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GroupOneSchoolDatabase.Models;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase
{
 
    public static class FluentNHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitialiseSessionFactory();
                }
                return _sessionFactory;
            }
        }
        public static void InitialiseSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\GroupOneSchoolDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();//Initialise Session Factory
        }
        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
        public static void AdmitStudents(StudentModel Student)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(Student);
                transaction.Commit();
            }

        }
        //public static void AddSchool(SchoolModel School)
        //{
        //    var session = OpenSession();
        //    using (var transaction = session.BeginTransaction())
        //    {
        //        session.Save(School);
        //        transaction.Commit();
        //    }

        //}
        public static void AddModel<T>(T Model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(Model);
                transaction.Commit();
            }

        }
        public static void UpdateModel<T>(T Model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Update(Model);
                transaction.Commit();
            }
        }

        public static void DeleteModel<T>(T Model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(Model);
                transaction.Commit();
            }
        }
        public static T ReadModel<T>(int Id)
        {
            var session = OpenSession();
            var model = session.Get<T>(Id);
            return model;
        }
        public static List<T> ReadAllModel<T>()
        {
            var session = OpenSession();
            var model = session.Query<T>().ToList();
            return model;
        }
        public static List<SchoolModel> ReadAllById(int Id)
        {
            var session = OpenSession();
            var model = session.Query<SchoolModel>().Where(x => x.Id == Id);
            return model.ToList();


        }



    }

}


