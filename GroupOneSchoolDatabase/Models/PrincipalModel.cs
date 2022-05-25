using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupOneSchoolDatabase.Models
{
    public class PrincipalModel:EntityModel
    {
        public virtual OfficeModel Office { get; set; }
    }
}
