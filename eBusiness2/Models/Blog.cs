using System;
using System.Collections.Generic;

namespace eBusiness2.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title{ get; set; }
        public DateTime Date { get; set; }
        public string Desc { get; set; }
        public string BlockQuote { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
