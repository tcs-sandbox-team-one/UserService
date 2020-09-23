﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserService.Database.Entities
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
