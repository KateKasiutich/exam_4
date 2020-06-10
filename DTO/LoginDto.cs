using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoginDto
    {
        public string FullName { get; set; }
        public int PersonalId { get; set; }

        public LoginDto (string fullName, int personalId)
        {
            FullName = fullName;
            PersonalId = personalId;
        }
    }
}
