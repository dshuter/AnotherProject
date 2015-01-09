using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnotherProject.Models
{
    public class SubProduct
    {
        public int SubProductID { get; set; }

        public string NewSubProductName { get; set; }

       


        public virtual ICollection<Product> Products { get; set; }
    }
}