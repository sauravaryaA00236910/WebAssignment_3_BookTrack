using System;
using System.ComponentModel.DataAnnotations;

namespace WebAssignment_3_BookTrack.Data
{
    public class Book
    {
        [Key]
        [StringLength(128, MinimumLength = 1)]
        public string ISBN { get; set; }

        [StringLength(128, MinimumLength = 1)]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [StringLength(128, MinimumLength = 1)]
        [Display(Name = "Book Category")]
        public string category { get; set; }

        [StringLength(128, MinimumLength = 1)]
        [Display(Name = "Book Author")]
        public string Author { get; set; }
    }
}
