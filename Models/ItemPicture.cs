using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class ItemPicture
    {
        public int Id { get; set; }

        [Requred]
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string Picture { get; set; }
    }
}
