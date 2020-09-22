using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiMe.Models
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }


        public ICollection<PostTag> PostTags{ get; set; }
    
      }
}