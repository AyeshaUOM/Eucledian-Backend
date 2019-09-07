using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Etudiant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentsController : Controller
    {
        public EtudiantContext Context { get; }

        public ParentsController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var parents = Context.Parents.Include(t => t.Students);
            return new ObjectResult(parents);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(Parent parent)
        {
            Context.Parents.Update(parent);
            Context.SaveChanges();
            return parent.Id;
        }

        [HttpGet("get/{id}")]
        public ActionResult<Parent> Get(int id)
        {
            var parent = Context.Parents.Find(id);
            return parent;
        }
      
    }
}