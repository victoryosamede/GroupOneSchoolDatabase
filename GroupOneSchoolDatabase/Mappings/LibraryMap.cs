using FluentNHibernate.Mapping;
using GroupOneSchoolDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Mappings
{
    public class LibraryMap:ClassMap<LibraryModel>
    {
        public LibraryMap()
        {
            Id(x =>x.Id);
            HasOne(x => x.Librarian);
            HasMany(x=>x.Books);

        }
    }
}
