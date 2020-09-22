using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiMe.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }



        public virtual ICollection<Post> Posts { get; set; }
    }
}