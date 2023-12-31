using Microsoft.EntityFrameworkCore;
using DemoMVC.Models;
namespace DemoMVC.Data{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person{ get; set;}  
        public DbSet<DemoMVC.Models.Employee> Employee { get; set; } = default!;
        public DbSet<DemoMVC.Models.DaiLy> DaiLy { get; set; } = default!;
        public DbSet<DemoMVC.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
        public DbSet<DemoMVC.Models.Faculty> Faculty { get; set; } = default!;
        public DbSet<DemoMVC.Models.Student> Student { get; set; } = default!;
    }
}