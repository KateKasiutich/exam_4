using DAL_Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Impl
{
    public class TeacherRepository : EFCoreRepository<int, TeacherEntity>, ITeacherRepository
    {
        public ClassEntity GetClasses(int teacherId)
        {
            throw new NotImplementedException();
        }
    }
}
