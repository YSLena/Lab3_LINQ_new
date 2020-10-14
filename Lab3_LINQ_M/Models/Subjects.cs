using System;
using System.Collections.Generic;

namespace Lab3LINQ_M.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
            Curriculum = new HashSet<Curriculum>();
        }

        public int SubjectId { get; set; }
        public string Name { get; set; }
        public int? ChairId { get; set; }
        public string ChairExternal { get; set; }

        public virtual ICollection<Curriculum> Curriculum { get; set; }
    }
}
