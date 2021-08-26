using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class MVCProductModel
    {
        public int ProductID { get; set; }

        [Required]
        public string ProductName { get; set; }
        public string ProductDesc { get; set; }
        [Required]
        public Nullable<int> Price { get; set; }

    }
}