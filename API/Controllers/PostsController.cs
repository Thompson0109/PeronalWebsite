using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Personal_Website_Project.Models;
using Personal_Website_Project.Services;

namespace Personal_Website_Project.Controllers
{
    [ApiController] 
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        readonly BlogContext _context;

        public PostsController(BlogContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet("GetBlogPost")]
        public ActionResult<IEnumerable<BlogPost>> Get()
        {
            return _context.BlogPosts;
        }

        // GET api/posts/5
        [HttpGet("{id}")]
        public ActionResult<BlogPost> Get(int id)
        {
            return _context.BlogPosts.FirstOrDefault(post => post.BlogPostId == id);
        }

        // POST api/posts
        [HttpPost("CreateBlogPost")]
        public void Post([FromBody] BlogPost value)
        {
            _context.BlogPosts.Add(value);
            _context.SaveChanges();
        }

        // PUT api/posts/5
        [HttpPut("{id}")]
        public  void Put(int id, [FromBody] BlogPost value)
        {
            var post =  _context.BlogPosts.FirstOrDefault(p => p.BlogPostId == id);
            if (post == null)
                return;
            
            post.Title = value.Title;
            post.Summary = value.Summary;
            post.Body = value.Body;
            post.AuthorId = value.AuthorId;

            _context.BlogPosts.Update(post);
            _context.SaveChanges();
        }

        // DELETE api/posts/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var post = _context.BlogPosts.FirstOrDefault(p => p.BlogPostId == id);
            if (post == null)
                return;

            _context.BlogPosts.Remove(post);
            _context.SaveChanges();
        }
    }
 }
