using Microsoft.EntityFrameworkCore;
using Personal_Website_Project.Models;

namespace Personal_Website_Project.Services
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public BlogContext() { }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}