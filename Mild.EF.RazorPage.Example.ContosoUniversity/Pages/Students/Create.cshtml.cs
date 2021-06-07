using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mild.EF.RazorPage.Example.ContosoUniversity.Data;
using Mild.EF.RazorPage.Example.ContosoUniversity.Models;

namespace Mild.EF.RazorPage.Example.ContosoUniversity.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly Mild.EF.RazorPage.Example.ContosoUniversity.Data.SchoolContext _context;

        public CreateModel(Mild.EF.RazorPage.Example.ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
