using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _.NET_Advanced_paskaitos
{
    public class Store
    {
        public DateTime CreationDate { get; set; }
        public List<string> Products { get; set; }
        public string ShopName { get; set; }

        public Store()
        {
            CreationDate = DateTime.Now;
            Products = new List<string>();
            ShopName = "Robo SHOP";
        }
    }
}
