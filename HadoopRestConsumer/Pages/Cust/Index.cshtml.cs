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
    public class IndexModel : PageModel
    {
        private readonly HadoopRestConsumer.Data.AppDbContext _context;

        public IndexModel(HadoopRestConsumer.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
