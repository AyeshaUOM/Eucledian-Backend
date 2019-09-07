using Etudiant.Attributes;
using Etudiant.Models;
using Etudiant.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private EtudiantContext _context;
        private FileManager _fileManager;

        public StudentsController(EtudiantContext context, FileManager fileManager)
        {
            _fileManager = fileManager;
            _context = context;
        }


        public IActionResult Index()
        {
            var std = _context.Students.Where(t => t.Status == true).Include(st => st.StudentClass);
            return new ObjectResult(std);
        }

        [HttpPost("create")]
        [ValidateModel]
        public IActionResult Create(Student student)
        {
            // Save Image
            if (!string.IsNullOrEmpty(student.Photo))
            {
                string base64 = student.Photo;
                var filePath = Path.Combine(string.Format("Uploads/Students/{0}.png", student.IndexNumber));
                _fileManager.SaveFile(filePath, base64);

                student.Photo = student.IndexNumber;
            }

            _context.Update(student);
            _context.SaveChanges();

            return new ObjectResult(student);
        }

        [HttpGet("image/{index}")]
        public IActionResult Image(string index)
        {
            FileStream image = null;
            var path = string.Format(@"Uploads/Students/{0}.png", index);

            if (System.IO.File.Exists(path))
            {
                image = System.IO.File.OpenRead(path);
            }
            else
            {
                path = string.Format(@"Uploads/Students/{0}.png", "placeholder");
                image = System.IO.File.OpenRead(path);
            }

            return File(image, "image/png");
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            var student = _context.Students.Include(t => t.StudentClass)
                         .Where(t => t.Id == id).FirstOrDefault();

            return new ObjectResult(student);
        }

    }
}