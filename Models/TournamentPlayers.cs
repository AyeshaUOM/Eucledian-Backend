using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Etudiant.Models
{
    public class TournamentPlayers
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        public int PlayerId { get; set; }
        public virtual Student Player { get; set; }

        [ForeignKey("Tournament")]
        public int TournamentId { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
