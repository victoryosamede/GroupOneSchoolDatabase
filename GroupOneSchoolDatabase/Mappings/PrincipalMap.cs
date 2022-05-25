using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class PrincipalMap:ClassMap<PrincipalModel>
    {
        public PrincipalMap()
        {
            Id(x=>x.Id);
            Map(x => x.Name);
            HasOne(x => x.Office);
        }
    }
}
