
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class GoodReceiveNote_Main
    {
        public int id { get; set; }
        public int LotId { get; set; }

        [Requred]
        public Decimal TotalCostPrice { get; set; }

        [Requred]
        public DateTime Date { get; set; }

        [DefaultValue(0)]
        public decimal Discount { get; set; }

        public string Note { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }
        //RelationShips
        public User user { get; set; }
        public Branch branch { get; set; }
        
        public GoodReceiveNote_Main()
        {
            Date= new DateTime().ToUniversalTime();
        }

    }
}
