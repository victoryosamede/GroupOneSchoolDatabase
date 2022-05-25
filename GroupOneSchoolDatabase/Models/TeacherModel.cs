using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class TeacherModel : EntityModel
    {
        public virtual SubjectModel Subjects { get; set; }

        public virtual List<ClassroomModel> Classrooms { get; set; }

        public virtual SchoolModel School { get; set; }

        public virtual OfficeModel Office { get; set; }
    }
}
