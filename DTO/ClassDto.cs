using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassDto
    {
        public string Title { get; set; }
        public int ClassID { get; set; }

        public ClassDto(string title, int classId )
        {
            ClassID = classId;
            Title = title;
        }
    }
}
