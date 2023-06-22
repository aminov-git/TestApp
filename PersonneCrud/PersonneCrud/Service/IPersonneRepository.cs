using PersonneCrud.Model;

namespace PersonneCrud.Service
{
    public interface IPersonneRepository
    {
        void SauvegarderPersonne(Personne personne);
        Task<IEnumerable<PersonneAvecAge>> ObtenirPersonnesParOrdreAlphabetique();

    }
}
