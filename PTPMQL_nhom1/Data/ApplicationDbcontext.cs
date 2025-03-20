using Microsoft.EntityFrameworkCore;
using PTPMQL.Models;
using PTPMQL;

namespace PTPMQL.Data
{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions <ApplicationDbContext>options) : base(options)
    {}
    public DbSet<Person> Persons { get; set; }
        public object Person { get; internal set; }
    public DbSet<PTPMQL.Employee> Employee { get; set; } = default!;
    public DbSet<PTPMQL.Nhanvien> Nhanvien { get; set; } = default!;
    }
}