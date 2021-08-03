using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAssignment_3_BookTrack.Data;
using WebAssignment_3_BookTrack.Data.Context;

namespace WebAssignment_3_BookTrack.Pages.BookTrackAdmin.CategoryTypeAdmin
{
    public class CreateModel : PageModel
    {
        private readonly WebAssignment_3_BookTrack.Data.Context.CategoryTypeContext _context;

        public CreateModel(WebAssignment_3_BookTrack.Data.Context.CategoryTypeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryType CategoryType { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CategoryTypes.Add(CategoryType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
