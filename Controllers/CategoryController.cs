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
    public class CategoryController : ControllerBase
    {
        public EtudiantContext Context { get; }

        public CategoryController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var category = Context.categories;
            return new ObjectResult(category);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(Category category)
        {
            Context.categories.Update(category);
            Context.SaveChanges();
            return category.Id;
        }

        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            var category = Context.categories.Find(id);
            return category;
        }
    }
}