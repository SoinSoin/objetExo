namespace myApp.Objet
{
    public class Competence
    {
        public int Atk { get; set; }

        public int Atkspe { get; set; }

        public int Def { get; set; }
        public int Defspe { get; set; }
        public int Vie { get; set; }
        public int Niv { get; set; }


        public Competence(int niv)
        {
            Niv = niv;
            Vie = niv*12;
            Atk = niv*8;
            Atkspe = Atk*niv;
            Def = niv*7;
            Defspe = Def *niv;

        }
    }
}