using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnTheJob.Data;
using OnTheJob.Models;

namespace OnTheJob.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        private readonly OnTheJob.Data.OnTheJobContext _context;

        public CreateModel(OnTheJob.Data.OnTheJobContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Job Job { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Job == null || Job == null)
            {
                return Page();
            }

            _context.Job.Add(Job);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
