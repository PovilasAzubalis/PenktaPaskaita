namespace _2AntraUzduotis_KortuZaidimas.Models
{
        internal class Korta
        {
                string kortosVerte { get; set; }
                string kortosSimbolis { get; set; }

                public Korta(string kortosVerte, string kortosSimbolis)
                {
                        this.kortosVerte = kortosVerte;
                        this.kortosSimbolis = kortosSimbolis;
                }

                public override string ToString()
                {
                        return kortosVerte + kortosSimbolis;
                }
        }

}

