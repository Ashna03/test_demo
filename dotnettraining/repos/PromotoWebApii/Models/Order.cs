using System;
using System.Collections.Generic;

#nullable disable

namespace PromotoWebApii.Models
{
    public partial class Order
    {
        public string OrderId { get; set; }
        public string CustomerName { get; set; }
        public int? Pid { get; set; }
        public DateTime? Dop { get; set; }
        public int? Qty { get; set; }

        public virtual Product PidNavigation { get; set; }
    }
}
