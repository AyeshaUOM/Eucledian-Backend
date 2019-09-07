using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Item Name")]
        public string Name { get; set; }
        [Required]
        public decimal CostPrice { get; set; }
        [Required]
        public decimal SellPrice { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }
        //Relationships
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public SubCategory subCategory { get; set; }
        public ICollection<ItemPicture> ItemPicture { get; set; }
       
    }
}
