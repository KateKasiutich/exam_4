using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Abstract
{
    public interface IChildRepository : IRepository<int, ChildEntity>
    {
        bool HasClass(int childID);
        ChildEntity GetParents(int parentid);
    }
}
