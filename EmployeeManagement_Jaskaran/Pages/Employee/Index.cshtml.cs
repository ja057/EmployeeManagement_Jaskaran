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
    public class IndexModel : PageModel
    {
        private readonly EmployeeManagement_Jaskaran.Data.ApplicationDbContext _context;

        public IndexModel(EmployeeManagement_Jaskaran.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Buss.Employee> Employee { get;set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees
                .Include(e => e.Department)
                .Include(e => e.Designation).ToListAsync();
        }
    }
}
