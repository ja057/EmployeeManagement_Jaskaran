using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement_Jaskaran.Buss;
using EmployeeManagement_Jaskaran.Data;

namespace EmployeeManagement_Jaskaran.Pages.Designation
{
    public class DeleteModel : PageModel
    {
        private readonly EmployeeManagement_Jaskaran.Data.ApplicationDbContext _context;

        public DeleteModel(EmployeeManagement_Jaskaran.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Buss.Designation Designation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Designation = await _context.Designations.FirstOrDefaultAsync(m => m.ID == id);

            if (Designation == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Designation = await _context.Designations.FindAsync(id);

            if (Designation != null)
            {
                _context.Designations.Remove(Designation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
