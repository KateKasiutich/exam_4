using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Abstract
{
    public interface IAuthService : IDisposable
    {
        bool Registration(RegisterDto regInfo, int id);
        bool Authentication(LoginDto logInfo, int id);
        void SignOut();
    }
}
