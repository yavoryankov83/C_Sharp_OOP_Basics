using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Reply
    {
        public Reply(int id, string content, int authorId, int postId)
        {
            this.Id = id;
            this.Content = content;
            this.AuthorId = authorId;
            this.PostId = postId;
        }

        public int Id { get; private set; }
        public string Content { get; private set; }
        public int AuthorId { get; private set; }
        public int PostId { get; private set; }
    }
}
