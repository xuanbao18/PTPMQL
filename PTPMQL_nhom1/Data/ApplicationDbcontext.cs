using Microsoft.EntityFrameworkCore;
using PTPMQL.Models;

namespace PTPMQL_Nhom1.Data
{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions <ApplicationDbContext>options) : base(options)
    {}
    public DbSet<Person> Persons { get; set; }
        public object Person { get; internal set; }
    }
}