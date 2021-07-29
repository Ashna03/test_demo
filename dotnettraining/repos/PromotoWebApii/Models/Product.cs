using System;
using System.Collections.Generic;

#nullable disable

namespace PromotoWebApii.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Category { get; set; }
        public int? Qty { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
