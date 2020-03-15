using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.models
{
    class Category
    {

        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name="Category Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Display Order")]
        public int DisplayOrder { get; set; }
    }
}
