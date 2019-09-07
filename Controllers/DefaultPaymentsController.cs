using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Mvc;

namespace Etudiant.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DefaultPaymentsController
    {
        public EtudiantContext Context { get; }

        public DefaultPaymentsController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var DefaultPayments = Context.DefaultPayments;
            return new ObjectResult(DefaultPayments);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(DefaultPayment defaultPayment)
        {
            Context.DefaultPayments.Update(defaultPayment);
            Context.SaveChanges();
            return defaultPayment.Id;
        }

        [HttpGet("get/{id}")]
        public ActionResult<DefaultPayment> Get(int id)
        {
            var DefaultPayments = Context.DefaultPayments.Find(id);
            return DefaultPayments;
        }
    }
}
