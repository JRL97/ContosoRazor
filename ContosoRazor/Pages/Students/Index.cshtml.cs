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
    public class IndexModel : PageModel
    {
        private readonly ContosoRazor.Data.ApplicationDbContext _context;

        public IndexModel(ContosoRazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
