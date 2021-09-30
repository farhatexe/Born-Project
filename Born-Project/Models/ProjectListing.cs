using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Born_Project.Models
{
    public class ProjectListing<T> : List<T>
    {
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public string FilterStatus { get; set; }
        public ProjectListing(List<T> items, int count, int pageIndex, int pageSize, string filterStatus)
        {
            PageIndex = pageIndex;
            FilterStatus = filterStatus;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            this.AddRange(items);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<ProjectListing<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize, string filterStatus)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
            return new ProjectListing<T>(items, count, pageIndex, pageSize, filterStatus);
        }
    }
}
