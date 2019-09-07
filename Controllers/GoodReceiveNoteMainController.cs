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
    public class GoodReceiveNoteMainController : ControllerBase
    {

        public EtudiantContext Context { get; }

        public GoodReceiveNoteMainController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var grn = Context.goodReceiveNote_Mains.Include(t => t.branch)
                                                   .Include(t => t.user).
                                                   Include(t => t.branch);
            return new ObjectResult(grn);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(GoodReceiveNote_Main goodReceiveNote_Main)
        {
            Context.goodReceiveNote_Mains.Update(goodReceiveNote_Main);
            Context.SaveChanges();
            return goodReceiveNote_Main.id;
        }

        [HttpGet("{id}")]
        public ActionResult<GoodReceiveNote_Main> Get(int id)
        {
            var grn = Context.goodReceiveNote_Mains.Include(t => t.branch)
                                                    .Include(t => t.user).
                                                    Include(t => t.branch).
                                                     FirstOrDefault();
            return grn;
        }
    }
}