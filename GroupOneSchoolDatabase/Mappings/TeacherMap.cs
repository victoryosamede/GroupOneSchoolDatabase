using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class TeacherMap:ClassMap<TeacherModel>
    {
        public TeacherMap()
        {
            Id(x=>x.Id);
            Map(x => x.Name);
            HasMany(x => x.Classrooms);
            References(x => x.School);
            References(x=>x.Office);
            References(x=>x.Subjects);
        }
    }
}
