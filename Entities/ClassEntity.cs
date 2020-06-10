using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClassEntity
    {
        public string Title { get; set; }
        public int ClassID { get; set; }
        public int TeacherId { get; set; }
        public TeacherEntity Teacher { get; set; }
    }
}
