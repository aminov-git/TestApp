using Microsoft.EntityFrameworkCore;
using PersonneCrud.Model;

namespace PersonneCrud.DbContexts
{
    public class PersonneContext : DbContext
    {
        public DbSet<Personne> personnes { get; set; }

        public PersonneContext(DbContextOptions<PersonneContext> options)
            : base(options)
        {

        }
    }
}
