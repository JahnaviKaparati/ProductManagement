using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModels.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartItemId { get; set; }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
