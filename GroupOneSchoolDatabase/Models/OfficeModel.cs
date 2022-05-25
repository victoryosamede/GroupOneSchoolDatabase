using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class OfficeModel:EntityModel
    {
        public virtual List<TeacherModel> Teachers { get; set; }

        public virtual List<NonAcademicStaffModel> NonAcademicStaff { get; set; }
    }
}
