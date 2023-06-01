using Microsoft.EntityFrameworkCore;
using Personal_Website_Project.Models;

namespace Personal_Website_Project.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {}
        
            public DbSet<BlogPost> BlogPosts { get; set; }
    
            public DbSet<Author> Authors { get; set; }
        

    }
