using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class SubjectsMap:ClassMap<SubjectModel>
    {
        public SubjectsMap()
        {
            Id(x=>x.Id);
            Map(x => x.Name);
            HasMany(x => x.Teachers);
            HasManyToMany(x=>x.Students);
        }
    }
}
