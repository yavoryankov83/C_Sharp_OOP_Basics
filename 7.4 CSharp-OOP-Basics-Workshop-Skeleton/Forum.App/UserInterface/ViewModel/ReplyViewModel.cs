using Forum.App.Services;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.UserInterface.ViewModel
{
    public class ReplyViewModel
    {
        public ReplyViewModel()
        {
            this.Content = new List<string>();
        }

        public ReplyViewModel(Reply reply)
        {
            this.Author = UserService.GetUser(reply.AuthorId).Username;
            this.Content = GetLines(reply.Content);
        }
        private const int LINE_LENGTH = 37;

        public string Author { get; set; }
        public IList<string> Content { get; set; }

        private IList<string> GetLines(string content)
        {
            var contentChars = content.ToCharArray();
            IList<string> lines = new List<string>();

            for (int i = 0; i < contentChars.Length; i += LINE_LENGTH)
            {
                char[] row = contentChars.Skip(i).Take(LINE_LENGTH).ToArray();
                string rowString = string.Join("", row);
                lines.Add(rowString);
            }

            return lines;
        }
    }
}
