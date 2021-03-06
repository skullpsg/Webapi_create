﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogWebApi.Entities
{
    public class UserEntity : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        
        [Required]
        public byte Level { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        [Required]
        public string Company { get; set; }

    }
}