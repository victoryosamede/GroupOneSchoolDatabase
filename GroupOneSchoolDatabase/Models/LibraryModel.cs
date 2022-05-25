using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class LibraryModel
    {
        public virtual int Id { get; set; }
        public virtual NonAcademicStaffModel Librarian { get; set; }
        
        public virtual List<BookModel> Books { get; set; }
    }
}
