using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_mlabar26.Models
{
    public class movieForm
    {
        [Key]
        [Required]
        public int movieID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        public string year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lent { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }
        
        //Foreign Key Relationship
        [Required(ErrorMessage = "Category is required")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
