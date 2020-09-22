using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiMe.DAL;
using ApiMe.DTOs;
using ApiMe.Models;
using AutoMapper;
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
       public IEnumerable<PostDTOs> GetPosts()
        {

            List<PostDTOs> AllPost = new List<PostDTOs>();
            var post = _context.Posts.ToList();
               
            foreach (var One in post)
            {
                var postById = _context.Posts.
                Include(pt => pt.Comments)
                .Include(cat => cat.Category)
                .Include(ta => ta.Tag).SingleOrDefault(c => c.PostId == One.PostId);

                if (postById != null)
                    AllPost.Add(Mapper.Map<Post, PostDTOs>(postById));

               
            }

            return AllPost;
        }


        [HttpGet]
        public PostDTOs GetPost(int id)
        {

            var post = _context.Posts.
                Include(pt => pt.Comments)
                .Include(cat => cat.Category)
                .Include(ta => ta.Tag).SingleOrDefault(c => c.PostId == id);

             if (post == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            PostDTOs postById = Mapper.Map<Post, PostDTOs>(post);
            return postById;
        }

        [HttpPost]
        public Post CreatePost(Post post,Tag tag, Category category)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Add(post);
            _context.SaveChanges();
            return post;

        }

        [HttpPut]
        public void PostUpdate(Post post, int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);


            var PostDb = _context.Posts.SingleOrDefault(p => p.PostId == id);

            if (PostDb == null)
                throw new HttpResponseException(HttpStatusCode.NoContent);

                PostDb.CategoryId = post.CategoryId;
            PostDb.PostDate = post.PostDate;
            PostDb.PostDescription = post.PostDescription;
            PostDb.Comments = post.Comments;
            _context.Posts.Update(PostDb);
            _context.SaveChanges();
                
        }
        [HttpDelete]
        public void PostDelete(int id)
        {
            var PostDbDelete = _context.Posts.SingleOrDefault(p => p.PostId == id);
            if (PostDbDelete == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Posts.Remove(PostDbDelete);
            _context.SaveChanges();
        }

    }
}
