using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEFCoreOverview.Models
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
        public double Weight { get; set; }
        public Book Book { get; set; }

    }
}
