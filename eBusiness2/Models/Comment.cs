using System;

namespace eBusiness2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
