using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public Category categoryId { get; set; }


    }
}