using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnTheJob.Data;
using OnTheJob.Models;

namespace OnTheJob.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly OnTheJob.Data.OnTheJobContext _context;

        public IndexModel(OnTheJob.Data.OnTheJobContext context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Job != null)
            {
                Job = await _context.Job.ToListAsync();
            }
        }
    }
}
