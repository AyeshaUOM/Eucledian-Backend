using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Etudiant.Models
{
    public class EtudiantContext : DbContext
    {
        public EtudiantContext(DbContextOptions<EtudiantContext> options) : base(options)
        {

        }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Sibbing> Sibbings { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<DefaultPayment> DefaultPayments { get; set; }

        public DbSet<Attendance> Attendances { get; set; }

        public DbSet<Class> Classes { get; set; }

        public DbSet<StudentClass> studentClasses { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<SubCategory> subCategories { get; set; }

        public DbSet<Item> items { get; set; }

        public DbSet<ItemPicture> itemPictures { get; set; }

        public DbSet<GoodReceiveNote_Main> goodReceiveNote_Mains { get; set; }

        public DbSet<GoodReceiveNote_Sub> goodReceiveNote_Subs { get; set; }
        public DbSet<Tournament> tournament { get; set; }
        public DbSet<ExternalPlayer> externalPlayer { get; set; }

        public DbSet<Puzzle> puzzles { get; set; }
        public DbSet<StudentPuzzles> studentPuzzles { get; set; }

        public DbSet<TournamentPlayers> tournamentPlayers { get; set; }

    }

}
