using Microsoft.EntityFrameworkCore;
using PTPMQL.Models;

namespace PTPMQL.Data
{
public class ApplicationDbcontext : DbContext
{
    public ApplicationDbcontext(DbContextOptions <ApplicationDbcontext>options) : base(options)
    {}
    public DbSet<Person> Persons { get; set; }
        public object Person { get; internal set; }
    }
}