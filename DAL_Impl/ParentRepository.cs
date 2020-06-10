using DAL_Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Impl
{
    public class ParentRepository : EFCoreRepository<int, ParentEntity>, IParentRepository
    {
        public ParentEntity GetByPriority(int priority)
        {
            throw new NotImplementedException();
        }
    }
}
