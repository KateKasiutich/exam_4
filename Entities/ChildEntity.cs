using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ChildEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int ChildID { get; set; }
        public int ParentID { get; set; }
        public int ClassID { get; set; }
        public ParentEntity ParentEntity { get; set; }
        public ClassEntity ClassEntity { get; set; }
    }
}
