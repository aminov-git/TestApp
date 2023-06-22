namespace PersonneCrud.Model
{
    public class PersonneAvecAge
    {
        public Personne Personne { get; set; }
        public int Age { get; set; }

        public PersonneAvecAge(Personne personne, int age)
        {
            Personne = personne;
            Age = age;
        }
    }

}
