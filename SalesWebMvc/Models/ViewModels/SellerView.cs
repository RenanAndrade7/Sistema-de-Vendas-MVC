using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerView
    {
        public List<Seller> Seller { get; set; }
        public SalesRecord SalesRecord { get; set; }
    }
}
