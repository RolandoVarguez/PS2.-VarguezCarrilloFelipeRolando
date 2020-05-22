using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAFETERIA.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string DireccionClient { get; set; }

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string OrderStatus { get; set; }
    }
}