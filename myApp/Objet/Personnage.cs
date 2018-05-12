
namespace myApp.Objet
{
    public class Personnage : Competence
    {
        public string Nom { get; set; }

        public string Saclasse { get; set; }
        public string Genre { get; set; }



        public Personnage(string nom, string saclasse, string genre, int niv)
        : base(niv)
        {
            Nom = nom;
            Saclasse = saclasse;
            Genre = genre;
            Niv=niv;
        }

    }
}
