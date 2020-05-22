using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAFETERIA.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }

        public byte[] Imagen { get; set; }

    }
}