using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Personal_Website_Project.Models;

namespace Personal_Website_Project.Services
{
   public interface IBlogContext
    {
        DbSet<BlogPost> BlogPosts { get; set; }

        DbSet<Author> Authors { get; set; }
    }
}