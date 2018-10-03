using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Models
{
    public class Category
    {
        public Category(int id, string name, ICollection<int> postIds)
        {
            this.Id = id;
            this.Name = name;
            this.PostIds = new List<int>(postIds);
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public ICollection<int> PostIds { get; private set; }
    }
}
