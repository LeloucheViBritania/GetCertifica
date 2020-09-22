using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiMe.Models
{
    public class Post
    {

        [Key]
        public int PostId { get; set; }




        public int UserId { get; set; }
        public virtual User User { get; set; }


        public int CategoryId {get; set;}

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public int TadId { get; set; }

        public Tag Tag { get; set; }




    }
}