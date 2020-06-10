﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RegisterDto
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public RegisterDto (string fullName, string phoneNumber)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
        } 
    }
}
