using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ContosoRazor.Data;
using ContosoRazor.Models;

namespace ContosoRazor.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly ContosoRazor.Data.ApplicationDbContext _context;

        public DetailsModel(ContosoRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            Student = await _context.Students
         .Include(s => s.Enrollments)
         .ThenInclude(e => e.Module)
         .AsNoTracking()
         .FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = Student;
            }
            return Page();
        }
    }
}
