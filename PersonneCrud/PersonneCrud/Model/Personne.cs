using System.ComponentModel.DataAnnotations;

namespace PersonneCrud.Model
{
    public class Personne
    {
        [Key]
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public DateTime DateNaissance { get; set; }
    }
}
