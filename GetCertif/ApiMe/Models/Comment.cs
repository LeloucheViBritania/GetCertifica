using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiMe.Models
{
    public class Comment
    {
        [Key]

        public int CommentId { get; set; }


        public virtual Post Post{ get; set; }
    }
}