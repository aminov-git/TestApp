using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonneCrud.Model;
using PersonneCrud.Service;

namespace PersonneCrud.Controllers
{
    [Route("api/personnes")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        private readonly IPersonneRepository _personneRepository;
        public PersonneController(IPersonneRepository personneRepository)
        {
            _personneRepository = personneRepository ??
                throw new ArgumentNullException(nameof(personneRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonneAvecAge>>> GetPersonness(string? name)
        {
            var personnesAvecAge = await _personneRepository.ObtenirPersonnesParOrdreAlphabetique();
            return Ok(personnesAvecAge);

        }
        [HttpPost]
        public ActionResult AddPersonnes(Personne personne)
        {
            _personneRepository.SauvegarderPersonne(personne);
            return NoContent();
        }

    }
}
