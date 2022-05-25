using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class ClassroomMap:ClassMap<ClassroomModel>
    {
        public ClassroomMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x=>x.Students);
            HasOne(x=>x.ClassTeacher);
            References(x => x.School);
        }
    }
}
