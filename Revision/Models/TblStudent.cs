using System;
using System.Collections.Generic;

namespace Revision.Models
{
    public partial class TblStudent
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int DepartmentId { get; set; }
        public string MobileNumber { get; set; } = null!;

        public virtual TblDepartment Department { get; set; } = null!;
    }
}
