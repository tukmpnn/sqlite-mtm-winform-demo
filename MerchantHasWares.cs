using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite_mtm_winform_demo
{
    public class MerchantHasWares
    {
        public int MerchantID { get; set; }
        public virtual Merchant Merchant { get; set; }

        public int WareId { get; set; }
        public virtual Ware Ware { get; set; }

        public int Amount { get; set; }

    }
}
