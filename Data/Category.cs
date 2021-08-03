using System;
using System.ComponentModel.DataAnnotations;

namespace WebAssignment_3_BookTrack.Data
{
    public class Category
    {
        [Key]
        [StringLength(128, MinimumLength = 1)]
        public string NameToken { get; set; }

        [StringLength(128, MinimumLength = 1)]
        public string Type { get; set; }

        [StringLength(255, MinimumLength = 1)]
        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}
