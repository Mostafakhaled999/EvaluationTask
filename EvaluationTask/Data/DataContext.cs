using EvaluationTask.Model;
using Microsoft.EntityFrameworkCore;

namespace EvaluationTask.Data
{
    public class DataContext : DbContext
    {
        private readonly DataContext _context;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Shipment> Shipment { get; set; }

        public DbSet<Box> Box { get; set; }

        public DbSet<Envelope> Envelope { get; set; }

        public DbSet<Batch> Batch { get; set; }

        public DbSet<Paper> Paper { get; set; }
       
        public DbSet<Box> Document { get; set; }



    }
}
