using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etudiant.Models
{
    public class StudentPuzzles
    {

        public int Id { get; set; }

        [ForeignKey("Puzzle")]
        public int PuzzleId { get; set; }
        public virtual Puzzle Puzzle { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int NoofCorrectAnswers { get; set; }
        public DateTime IssueDate { get; set; }

        public DateTime SubmitDate { get; set; }
        [ForeignKey("User")]
        public int CollectedBy { get; set; }
        public virtual User CollectedUser { get; set; }

        [ForeignKey("User")]
        public int CorrectedBy { get; set; }
        public virtual User CorrectedUser { get; set; }
    }
}
