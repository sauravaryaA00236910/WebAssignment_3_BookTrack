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
    public class DeleteModel : PageModel
    {
        private readonly WebAssignment_3_BookTrack.Data.Context.CategoryTypeContext _context;

        public DeleteModel(WebAssignment_3_BookTrack.Data.Context.CategoryTypeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CategoryType CategoryType { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryTypes.FirstOrDefaultAsync(m => m.Type == id);

            if (CategoryType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryType = await _context.CategoryTypes.FindAsync(id);

            if (CategoryType != null)
            {
                _context.CategoryTypes.Remove(CategoryType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
