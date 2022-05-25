using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class StudentMap : ClassMap<StudentModel>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasManyToMany(x=>x.Subjects);
            HasOne(x => x.Classroom);
            References(x => x.School);
            
        }
    }
}
