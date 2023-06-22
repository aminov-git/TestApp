using PersonneCrud.DbContexts;
using PersonneCrud.Model;
using Microsoft.EntityFrameworkCore;


namespace PersonneCrud.Service
{
    public class PersonneRepository : IPersonneRepository
    {
        private readonly PersonneContext _context;

        public PersonneRepository(PersonneContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void SauvegarderPersonne(Personne personne)
        {
            if (CalculerAge(personne.DateNaissance) >= 150)
            {
                throw new Exception("Seules les personnes de moins de 150 ans peuvent être enregistrées.");
            }

            _context.personnes.Add(personne);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<PersonneAvecAge>> ObtenirPersonnesParOrdreAlphabetique()
        {
            List<PersonneAvecAge> personnesAvecAge = new List<PersonneAvecAge>();

            var tousPersonnes = await _context.personnes.OrderBy(p => p.Nom).ToListAsync();

            foreach (Personne personne in tousPersonnes)
            {
                int age = CalculerAge(personne.DateNaissance);
                personnesAvecAge.Add(new PersonneAvecAge(personne, age));
            }

            return personnesAvecAge;
        }

        private int CalculerAge(DateTime dateNaissance)
        {
            DateTime maintenant = DateTime.Today;
            int age = maintenant.Year - dateNaissance.Year;

            if (maintenant < dateNaissance.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
