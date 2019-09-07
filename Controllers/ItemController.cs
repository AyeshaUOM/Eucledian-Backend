using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Etudiant.Attributes;
using Etudiant.Models;
using Etudiant.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        public EtudiantContext Context { get; }

        public ItemController(EtudiantContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var item = Context.items.Include(t => t.Category)
                                    .Include(t =>t.subCategory)
                                    .Include(t =>t.ItemPicture)
                                    .ToList();
            return new ObjectResult(item);
        }

        [HttpPost("create")]
        [ValidateModel]
        public ActionResult<int> Create(Item item)
        {
            var newItem = new Item()
            {
                Id = item.Id,
                Active = true,
                CategoryId = item.CategoryId,
                Name = item.Name,
                SellPrice = item.SellPrice
            };
            Context.items.Update(newItem);
            Context.SaveChanges();

            var increment = 0;

            //add pictures
            foreach (var picture in item.ItemPicture)
            {
                increment++;

                if (picture.Picture == null && picture.Id != 0)
                {
                    Context.itemPictures.Remove(Context.itemPictures.Find(picture.Id));
                }
                else
                {
                    Context.itemPictures.Update(new ItemPicture()
                    {
                        Id = picture.Id,
                        ItemId = newItem.Id,


                });
                     Context.SaveChanges();

                }
            }
            return item.Id;

        }

        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            var item = Context.items.Include(t => t.Category)
                                    .Include(t => t.subCategory)
                                    .Include(t => t.ItemPicture).
                                     Where(t => t.Id == id)
                                    .SingleOrDefault();
                                    
            return item;
        }
    }
}