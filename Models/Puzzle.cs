using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Etudiant.Models
{
    public class Puzzle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ExerciseType { get; set; }
        public string Author { get; set; }

        public int NoofQuestions { get; set; }

    }
}
