using System;
using System.Collections.Generic;

namespace Revision.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
            TblStudents = new HashSet<TblStudent>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<TblStudent> TblStudents { get; set; }
    }
}
