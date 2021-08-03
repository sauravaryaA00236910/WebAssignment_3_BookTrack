using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignment_3_BookTrack.Data;
using WebAssignment_3_BookTrack.Data.Context;

namespace WebAssignment_3_BookTrack.Pages.BookTrackAdmin.CategoryTypeAdmin
{
    public class IndexModel : PageModel
    {
        private readonly WebAssignment_3_BookTrack.Data.Context.CategoryTypeContext _context;

        public IndexModel(WebAssignment_3_BookTrack.Data.Context.CategoryTypeContext context)
        {
            _context = context;
        }

        public IList<CategoryType> CategoryType { get;set; }

        public async Task OnGetAsync()
        {
            CategoryType = await _context.CategoryTypes.ToListAsync();
        }
    }
}
