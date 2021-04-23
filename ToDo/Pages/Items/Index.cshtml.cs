using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Pages_Items
{
    public class IndexModel : PageModel
    {
        private readonly ToDo.Data.ItemsContext _context;

        public IndexModel(ToDo.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get; set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}