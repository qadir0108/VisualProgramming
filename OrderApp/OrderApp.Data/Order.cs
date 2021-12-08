using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int Bill { get; set; }
    }
}
