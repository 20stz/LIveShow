﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiveShow.Dal.Models
{
    public class User
    {
        public long Id { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        public ICollection<Following> Followers { get; set; }

        public ICollection<Following> Followees { get; set; }

        public User()
        {
            Followers = new List<Following>();
            Followees = new List<Following>();
        }
    }
}
