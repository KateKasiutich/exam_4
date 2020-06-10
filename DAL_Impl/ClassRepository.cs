using DAL_Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Impl
{
    public class ClassRepository : EFCoreRepository<int, ClassEntity>, IClassRepository
    {
        public ChildEntity GetChildren(int classId)
        {
            throw new NotImplementedException();
        }

        public bool HasTeacher(int teacherId)
        {
            throw new NotImplementedException();
        }
    }
}
