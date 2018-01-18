using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HadoopRestConsumer.Data;

namespace HadoopRestConsumer.Pages.Cust
{
    public class DetailsModel : PageModel
    {
        private readonly HadoopRestConsumer.Data.AppDbContext _context;

        public DetailsModel(HadoopRestConsumer.Data.AppDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.SingleOrDefaultAsync(m => m.Email == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
