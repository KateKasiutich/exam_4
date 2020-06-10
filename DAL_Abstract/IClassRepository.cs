using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Abstract
{
    public interface IClassRepository : IRepository<int, ClassEntity>
    {
        ChildEntity GetChildren(int classId);
        bool HasTeacher(int teacherId);
    }
}
