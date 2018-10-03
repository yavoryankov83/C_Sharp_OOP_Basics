using Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    public class ForumData
    {
        public ForumData()
        {
            this.Categories = DataMapper.LoadCategories();
            this.Users = DataMapper.LoadUsers();
            this.Posts = DataMapper.LoadPosts();
            this.Replies = DataMapper.LoadReplies();
        }

        public List<Category> Categories { get; private set; }
        public List<User> Users { get; private set; }
        public List<Post> Posts { get; private set; }
        public List<Reply> Replies { get; private set; }

        public void SaveChanges()
        {
            DataMapper.SaveCategories(this.Categories);
            DataMapper.SaveUsers(this.Users);
            DataMapper.SavePosts(this.Posts);
            DataMapper.SaveReplies(this.Replies);
        }
    }
}
