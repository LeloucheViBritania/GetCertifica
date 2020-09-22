using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMe.DTOs
{
    public class PostDTOs
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }

        public string PostDescription { get; set; }
        public DateTime PostDate { get; set; }
        public int UserId { get; set; }
        public IList<CommentsDTO> CommentsDTOs { get; set; }
        public  TagDTO  TagDTO { get; set; }
    }
}