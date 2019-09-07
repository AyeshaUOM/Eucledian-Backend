using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class GoodReceiveNote_Sub
    {
        public int id { get; set; }

        public int Qty { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SellPrice { get; set; }

        public decimal Total { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }

        //RelationShips
        public Item item { get; set; }
        public GoodReceiveNote_Main goodReceiveNote_Main { get; set; }
    }
}
