using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Mvc;

namespace Etudiant.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PackagesController
    {
        public EtudiantContext Context { get; }

        public PackagesController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var Packages = Context.Packages;
            return new ObjectResult(Packages);
        }

        [HttpPost("create")]
        //[ValidateModel]
        public ActionResult<int> Create(Package package)
        {
            Context.Packages.Update(package);
            Context.SaveChanges();
            return package.Id;
        }

        [HttpGet("get/{id}")]
        public ActionResult<Package> Get(int id)
        {
            var Package = Context.Packages.Find(id);
            return Package;
        }
    }
}
