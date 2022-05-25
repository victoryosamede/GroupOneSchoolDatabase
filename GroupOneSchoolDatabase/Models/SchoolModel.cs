using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class SchoolModel:EntityModel
    {
       
        public virtual PrincipalModel Principal { get; set; }
        public virtual string Address { get; set; }

        public virtual List<StudentModel> Students { get; set; }

        public virtual List<TeacherModel> Teachers { get; set; }

        public virtual List<NonAcademicStaffModel> NonAcademicStaff { get; set; }

        public virtual List<OfficeModel> Office { get; set; }

        public virtual LibraryModel Library { get; set; }
    }
    
}
