using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class SubjectModel:EntityModel
    {
        public virtual List<TeacherModel> Teachers { get; set; }

        public virtual List<StudentModel> Students { get; set; }
    }
}
