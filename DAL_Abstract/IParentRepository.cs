using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Abstract
{
    public interface IParentRepository : IRepository<int, ParentEntity>
    {
        ParentEntity GetByPriority(int priority);

    }
}
