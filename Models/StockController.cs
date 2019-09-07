using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Etudiant.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        public int Id { get; set; }
        [Requred]
        public int Qty { get; set; }

        [Requred]
        public decimal CostPrice { get; set; }
       //RelationShips
        public Item item { get; set; }      
        public Branch branch { get; set; }
    }
}