using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        public EtudiantContext Context { get; }

        public SubCategoryController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var subcategory = Context.subCategories.Include(t => t.category);
            return new ObjectResult(subcategory);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(SubCategory subCategory)
        {
            Context.subCategories.Update(subCategory);
            Context.SaveChanges();
            return subCategory.Id;
        }

        [HttpGet("{id}")]
        public ActionResult<SubCategory> Get(int id)
        {
            var subcategory = Context.subCategories.Find(id);
            return subcategory;
        }
    }
}