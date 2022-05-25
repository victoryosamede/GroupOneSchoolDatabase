using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class BookMap:ClassMap<BookModel>
    {
        public BookMap()
        {
            Id(x=>x.Id);
            Map(x=>x.Name);
        }
    }
}
