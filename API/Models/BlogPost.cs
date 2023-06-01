using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Personal_Website_Project.Models
{
    public class BlogPost
    {
        [Key]
         public int BlogPostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Body { get; set; }
      //  public string[] Tags { get; set; }
        public int AuthorId { get; set; }
      //  public Author? Author { get; set; }
    }
}