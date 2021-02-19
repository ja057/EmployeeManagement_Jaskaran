using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement_Jaskaran.Buss;
using EmployeeManagement_Jaskaran.Data;

namespace EmployeeManagement_Jaskaran.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        private readonly EmployeeManagement_Jaskaran.Data.ApplicationDbContext _context;

        public DetailsModel(EmployeeManagement_Jaskaran.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Buss.Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation).FirstOrDefaultAsync(m => m.ID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
