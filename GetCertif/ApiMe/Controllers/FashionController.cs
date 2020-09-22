using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiMe.DAL;
using ApiMe.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMe.Controllers
{
    public class FashionController : ApiController
    {
        private CertiDbContext _context;
        public FashionController()
        {
            _context = new CertiDbContext();
        }

        [HttpGet]
       public IEnumerable<Post> GetPosts()
        {
           return _context.Posts.ToList();
        }


    /*   [HttpGet]
      *//*  public Post GetPost (int id)
        {
         
            var post = _context.Posts.Include(pt=>pt.PostTags).ThenInclude()
            if (post == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return post;
        }


        public Post CreatePost()*/
    }
}
