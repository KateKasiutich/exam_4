using DAL_Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Impl
{
    public class ChildRepository : EFCoreRepository<int, ChildEntity>, IChildRepository
    {
        public ChildEntity GetParents(int parentid)
        {
            throw new NotImplementedException();
        }

        public bool HasClass(int childID)
        {
            throw new NotImplementedException();
        }
    }
}
