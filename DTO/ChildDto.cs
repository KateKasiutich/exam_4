using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChildDto
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int ChildID { get; set; }
       
        public ChildDto(string fullName, int age, int childId)
        {
            FullName = fullName;
            Age = age;
            ChildID = childId;
        }
    }
}
