using Etudiant.Attributes;
using Etudiant.Dto;
using Etudiant.Models;
using Etudiant.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : Controller
    {
        private EtudiantContext _context;
        private FileManager _fileManager;

        public AttendanceController(EtudiantContext context, FileManager fileManager)
        {
            _fileManager = fileManager;
            _context = context;
        }

        public IActionResult Index()
        {
            var std = _context.Students;
            return new ObjectResult(std);
        }

        [ValidateModel]
        [HttpPost("create")]
        public IActionResult Create(Attendance attendance)
        {
            _context.Update(attendance);
            _context.SaveChanges();
            return Ok(attendance.Id);
        }

        [HttpGet("get/{id}")]
        public Student Get(int Id)
        {
            var Student = _context.Students.Where(t => t.Id == Id && t.Status == true).FirstOrDefault();
            return Student;
        }

        [HttpGet("markAttendance/{isAvailable}/{studentID}/{classID}/{currentDate}")]
        public void markAttendance(string isAvailable, int studentID, int classID, string currentDate)
        {
            string cuurDate = "";
            string[] arr = currentDate.Split('-');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 1)
                {
                    if (arr[i].Length == 1)
                    {
                        arr[i] = "0" + arr[i];
                    }
                }
                if (i == 2)
                {
                    cuurDate = cuurDate + arr[i];
                }
                else
                {
                    cuurDate = cuurDate + arr[i] + "-";
                }
            }
            int noOfRowUpdated = _context.Database.ExecuteSqlCommand(
                "IF EXISTS(select * from Attendances where studentId={0} and ClassId={1} and AccessDate = CONVERT(VARCHAR(10), {2}, 111)) " +
                "update Attendances set VeryfyMode = {3} where studentId={4} and ClassId={5} and AccessDate = CONVERT(VARCHAR(10), {6}, 111) " +
                "ELSE " +
                "insert into Attendances(AccessDate,veryfyMode,Edit,Active,ClassId,studentId) values({7},{8},{9},{10},{11},{12}); "
                , studentID, classID, cuurDate, isAvailable, studentID, classID, cuurDate, cuurDate, isAvailable, '0', '1', classID, studentID);
        }
        [HttpGet("getattendancebyclass/{ClassId}/{currentDate}")]
        public IActionResult GetAttendanceByClass(int ClassId, string currentDate)
        {
            string cuurDate = "";
            string[] arr = currentDate.Split('-');
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 1)
                {
                    if (arr[i].Length == 1)
                    {
                        arr[i] = "0" + arr[i];
                    }
                }
                if (i == 2)
                {
                    cuurDate = cuurDate + arr[i];
                }
                else
                {
                    cuurDate = cuurDate + arr[i] + "-";
                }
            }
            /*var qu = (from s in _context.Students
                      join a in _context.Attendances
                      on s.Id equals a.student.Id into jointable
                      where s.Class.Id == ClassId
                      from z in jointable.DefaultIfEmpty()
                      select new
                      {
                          s.FirstName,
                          s.LastName,
                          s.AdmissionFee,
                          availabilityToday = z.Id == null ? "0" : "1",
                      }).ToList();*/
            //where z.AccessDate == DateTime.Parse(currentDate)

            /*var qu = _context.Students.FromSql(
            "select s.*, " +
            "CASE " +
            "WHEN a.veryfyMode IS NULL THEN '0' " +
            "ELSE '1' " +
            "END AS AvailabilityToday " +
            "from Students s " +
            "Left join Attendances a " +
            "on s.Id = a.studentId  and a.AccessDate = CONVERT(VARCHAR(10), getdate(), 111) " +
            "where s.ClassId = {0}", ClassId).ToList();

            return new ObjectResult(qu);*/

            List<AttendanceDto> atdl = new List<AttendanceDto>();
            try
            {
                var query = "select s.*, " +
                    "CASE " +
                    "WHEN a.veryfyMode IS NULL THEN '0' " +
                    "WHEN a.veryfyMode=0 THEN '0' " +
                    "ELSE '1' " +
                    "END AS AvailabilityToday " +
                    "from Students s " +
                    "Left join Attendances a " +
                    "on s.Id = a.studentId  and a.AccessDate = CONVERT(VARCHAR(10), '" + cuurDate + "', 111) " +
                    "where s.ClassId = " + ClassId;

                using (SqlConnection connection = new SqlConnection("Data Source=72.9.145.118;Initial Catalog=goldenc1_etudiant;User ID=goldenc1_sa;Password=ES@teamwork;"))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                AttendanceDto p = new AttendanceDto();
                                p.ID = reader.GetInt32(reader.GetOrdinal("Id")) + "";
                                p.ClassID = reader.GetInt32(reader.GetOrdinal("ClassId")) + "";
                                p.AdmissionFee = reader.GetDecimal(reader.GetOrdinal("AdmissionFee")) + "";
                                p.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                p.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                                p.AvailabilityToday = reader.GetString(reader.GetOrdinal("AvailabilityToday"));
                                atdl.Add(p);
                            }
                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                string m = e.Message;

            }
            return new ObjectResult(atdl);
        }
    }
}