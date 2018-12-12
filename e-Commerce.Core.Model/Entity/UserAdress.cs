﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Commerce.Core.Model.Entity
{
    public class UserAdress:EntityBase
    {
        public int UserID { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public bool IsActive { get; set; }
    }
}
