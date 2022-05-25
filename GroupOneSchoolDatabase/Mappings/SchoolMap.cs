using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class SchoolMap:ClassMap<SchoolModel>
    {
        public SchoolMap()
        {
            Id(x=>x.Id);
            Map(x=>x.Name);
            HasOne(x=>x.Principal);
            Map(x=>x.Address);
            HasMany(x => x.Students);
            HasMany(x => x.Teachers);
            HasMany(x => x.NonAcademicStaff);
            HasMany(x=>x.Office);
            HasOne(x => x.Library);

        }
    }
}
