using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class StudentModel:EntityModel
    {
        public virtual List<SubjectModel> Subjects { get; set; }

        public virtual ClassroomModel Classroom { get; set; }

        public virtual SchoolModel School { get; set; }
    }
}
