﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
