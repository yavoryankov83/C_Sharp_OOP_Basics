using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Post
    {
        public Post(int id, string title, string content, int categoryId, int authorId, ICollection<int> replyIds)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.CategoryId = categoryId;
            this.AuthorId = authorId;
            this.ReplyIds = new List<int>(replyIds);
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int CategoryId { get; private set; }
        public int AuthorId { get; private set; }
        public ICollection<int> ReplyIds { get; private set; }
    }
}
