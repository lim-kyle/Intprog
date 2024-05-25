using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class CarsModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public List<Post> Posts { get; set; } = new List<Post>();

        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 9;
        public int TotalPages { get; set; }

		// Property for selected car brand
		[BindProperty(SupportsGet = true)]
		public string SelectedCarBrand { get; set; }


		public CarsModel(ApplicationDbContext context)
        {
            this.context = context;
        }

		public void OnGet(int? pageNumber)
		{
			PageNumber = pageNumber ?? 1;
			IQueryable<Post> query = context.Posts;

			// Filter by selected car brand
			if (!string.IsNullOrEmpty(SelectedCarBrand))
			{
				query = query.Where(p => p.CarBrand == SelectedCarBrand);
			}

			var totalPosts = query.Count();
			TotalPages = (int)Math.Ceiling(totalPosts / (double)PageSize);

			Posts = query
				.OrderByDescending(p => p.Id)
				.Skip((PageNumber - 1) * PageSize)
				.Take(PageSize)
				.ToList();
		}
	}
}
