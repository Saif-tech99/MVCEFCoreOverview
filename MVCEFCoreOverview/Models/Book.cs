using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEFCoreOverview.Models
{
    public class Book
    {

        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(20)]
        public string Genre { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public int YearPublished { get; set; }

        [Required]
        [StringLength(50)]
        public string Auther { get; set; }

        public bool IsBestSeller { get; set; }

        public int Counter { get; set; }

    }
}
