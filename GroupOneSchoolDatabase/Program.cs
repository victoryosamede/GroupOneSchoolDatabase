// See https://aka.ms/new-console-template for more information
using GroupOneSchoolDatabase.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using GroupOneSchoolDatabase;

Console.WriteLine("Hello, World!");


var StudentOne = new StudentModel() { Name = "Dozie", Id = 8  };
var StudentTwo = new StudentModel() { Name = "Zadok", Id = 9 };

FluentNHibernateHelper.AdmitStudents(StudentOne);
FluentNHibernateHelper.AdmitStudents(StudentTwo);
FluentNHibernateHelper.UpdateModel(StudentOne);

var SchoolOne = new SchoolModel()
{
    Id = 0,
    Name = "GroupOne International School",
    Address = "Microsoft Teams",
    Library = new LibraryModel() { Id = 5 },
    Principal = new PrincipalModel() { Name = "Ifesi", Id = 6 }
};
FluentNHibernateHelper.OpenSession();
FluentNHibernateHelper.AddModel<SchoolModel>(SchoolOne);

var School=FluentNHibernateHelper.ReadModel<SchoolModel>(0);
 

FluentNHibernateHelper.DeleteModel<StudentModel>(StudentTwo);
var TeacherOne = new TeacherModel() { Name = "Isaac", Id = 10 };
FluentNHibernateHelper.AddModel<TeacherModel>(TeacherOne);