using Microsoft.EntityFrameworkCore;
using Etudiant.Models;

namespace Etudiant.Services
{
    public class InitMigrations
    {
        private readonly EtudiantContext context;

        public InitMigrations(EtudiantContext context)
        {
            this.context = context;
        }
        public void MigrateDatabase()
        {
            context.Database.Migrate();
        }
    }
}