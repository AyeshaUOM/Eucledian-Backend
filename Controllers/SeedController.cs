using Etudiant.Attributes;
using Etudiant.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etudiant.Controllers
{
    public class SeedController
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

        }

    }
}
