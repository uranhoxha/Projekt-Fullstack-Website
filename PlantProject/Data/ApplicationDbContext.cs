using Microsoft.EntityFrameworkCore;
using PlantProject.Models;



namespace PlantProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Plant> Plants {  get; set; }
        public DbSet<aestheticPlants> AestheticPlants { get;set; }

        public DbSet<medicalPlants> MedicalPlants { get; set; }

        public DbSet<ediblePlants> EdiblePlants { get; set; }

    }
}
