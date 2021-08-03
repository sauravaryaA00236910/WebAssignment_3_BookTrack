using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignment_3_BookTrack.Data;
using WebAssignment_3_BookTrack.Data.Context;

namespace WebAssignment_3_BookTrack.Pages.BookTrackAdmin.CategoryAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly WebAssignment_3_BookTrack.Data.Context.CategoryContext _context;

        public DetailsModel(WebAssignment_3_BookTrack.Data.Context.CategoryContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Categories.FirstOrDefaultAsync(m => m.NameToken == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
