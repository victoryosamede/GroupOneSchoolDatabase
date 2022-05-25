using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class ClassroomModel:EntityModel
    {
        public virtual List<StudentModel> Students { get; set; }

        public virtual TeacherModel ClassTeacher { get; set; }
        public virtual SchoolModel School { get; set; }
    }
}
