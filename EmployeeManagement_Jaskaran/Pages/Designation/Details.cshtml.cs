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
    public class DetailsModel : PageModel
    {
        private readonly EmployeeManagement_Jaskaran.Data.ApplicationDbContext _context;

        public DetailsModel(EmployeeManagement_Jaskaran.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
