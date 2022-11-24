namespace AfficheurLCD.Test
{
    public class AfficheurNombresTest
    {
        [Fact]
        public void Test1()
        {
            // ETANT DONNE le chiffre 1
            const uint chiffre = 1;

            // QUAND on l'affiche en LCD
            var représentation = AfficheurNombres.Représenter(chiffre);

            // ALORS on obtient deux barres verticales à droite
            var attendu = "   " + Environment.NewLine +
                          "  |" + Environment.NewLine +
                          "  |";

            Assert.Equal(attendu, représentation);
        }
    }
}