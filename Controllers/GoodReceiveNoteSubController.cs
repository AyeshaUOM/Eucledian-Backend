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
    public class GoodReceiveNoteSubController : ControllerBase
    {
        public EtudiantContext Context { get; }

        public GoodReceiveNoteSubController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var grn = Context.goodReceiveNote_Subs.Include(t => t.goodReceiveNote_Main)
                                                   .Include(t => t.item);
            return new ObjectResult(grn);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(GoodReceiveNote_Sub goodReceiveNoteSub)
        {
            Context.goodReceiveNote_Subs.Update(goodReceiveNoteSub);
            Context.SaveChanges();
            return goodReceiveNoteSub.id;
        }

        [HttpGet("{id}")]
        public ActionResult<GoodReceiveNote_Sub> Get(int id)
        {
            var grn = Context.goodReceiveNote_Subs.Include(t => t.goodReceiveNote_Main)
                                                   .Include(t => t.item)
                                                   .FirstOrDefault();
            return grn;
        }
    }
}