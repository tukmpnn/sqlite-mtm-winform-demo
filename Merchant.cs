using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite_mtm_winform_demo
{
    public class Merchant
    {
        public int MerchantId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ware> Wares { get; set; }
    }
}
