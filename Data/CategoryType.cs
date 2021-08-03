using System;
using System.ComponentModel.DataAnnotations;

namespace WebAssignment_3_BookTrack.Data
{
    public class CategoryType
    {
        [Key]
        [StringLength(128, MinimumLength = 1)]
        public string Type { get; set; }

        [StringLength(128, MinimumLength = 1)]
        public string Name { get; set; }
    }
}
