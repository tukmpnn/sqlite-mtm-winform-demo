using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite_mtm_winform_demo
{
    public class Ware
    {
        public int WareId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Merchant> Merchants { get; set; }
    }
}
