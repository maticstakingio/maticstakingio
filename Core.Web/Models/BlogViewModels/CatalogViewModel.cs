using Core.Application.ViewModels.Blog;
using Core.Application.ViewModels.Common;
using Core.Utilities.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models.BlogViewModels
{
    public class CatalogViewModel
    {
        public CatalogViewModel()
        {
            Blogs = new List<BlogViewModel>();
            Tags = new List<TagViewModel>();
            SideBarBlogCategorys = new List<BlogCategoryViewModel>();
        }

        public PagedResult<BlogViewModel> Data { get; set; }
        public List<BlogViewModel> Blogs { set; get; }
        public TagViewModel Tag { get; set; }
        public List<TagViewModel> Tags { get; set; }
        public BlogCategoryViewModel BlogCategory { get; set; }
        public List<BlogCategoryViewModel> SideBarBlogCategorys { get; set; }
        public string SearchValue { get; set; }
        public string SortType { set; get; }

        public int? PageSize { set; get; }

    }
}
