using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using RazorCrudUI.Data;
using RazorCrudUI.Models;

namespace RazorCrudUI.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly RazorCrudUI.Data.ItemsContext _context;

        public IndexModel(RazorCrudUI.Data.ItemsContext context)
        {
            _context = context;
        }

        public IList<ItemModel> ItemModel { get;set; } = default!;



        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }



        public async Task OnGetAsync()
        {
            var items = from i in _context.Items select i;
            if (!string.IsNullOrEmpty(SearchString))
            {
                items = items.Where(i => i.Name.Contains(SearchString));
            }
            ItemModel = await items.ToListAsync();
        }
    }
}
