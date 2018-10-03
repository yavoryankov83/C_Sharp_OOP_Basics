﻿namespace Forum.App.Controllers
{
    using System;
    using System.Linq;
    using Forum.App.Controllers.Contracts;
    using Forum.App.Services;
    using Forum.App.UserInterface.Contracts;
    using Forum.App.Views;

    public class CategoryController : IController, IPaginationController
    {
        public CategoryController()
        {
            this.CurrentPage = 0;
            this.SetCategory(0);
        }

        private enum Command
        {
            Back = 0,
            ViewPost = 1,
            PreviousPage = 11,
            NextPage = 12
        }

        public const int PAGE_OFFSET = 10;
        private const int COMMAND_COUNT = PAGE_OFFSET + 3;

        public int CurrentPage { get; set; }
        private string[] PostTitles { get; set; }
        private int LastPage => this.PostTitles.Length / 11;
        private bool isFirstPage => this.CurrentPage == 0;
        private bool isLastPage => this.CurrentPage == this.LastPage;
        public int CategoryId { get; private set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.Back:
                    return MenuState.Back;

                case Command.ViewPost:
                    return MenuState.ViewPost;

                case Command.PreviousPage:
                    return MenuState.OpenCategory;

                case Command.NextPage:
                    return MenuState.OpenCategory;

                default:
                    throw new InvalidCommandException();
            }
        }

        public IView GetView(string userName)
        {
            GetPosts();
            string categoryName = PostService.GetCategory(this.CategoryId).Name;

            return new CategoryView(categoryName, this.PostTitles, this.isFirstPage, this.isLastPage);
        }

        public void SetCategory(int categoryId)
        {
            this.CategoryId = categoryId;
        }

        private void ChangePage(bool forward = true)
        {
            this.CurrentPage += forward ? 1 : -1;
            GetPosts();
        }

        private void GetPosts()
        {
            var allCategoryPosts = PostService.GetPostsByCategory(this.CategoryId);
            this.PostTitles = allCategoryPosts
                .Skip(this.CurrentPage * PAGE_OFFSET)
                .Take(PAGE_OFFSET)
                .Select(p => p.Title)
                .ToArray();
        }
    }
}
