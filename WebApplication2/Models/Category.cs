using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}