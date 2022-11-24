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
            var attendu = "   " + Environment.NewLine + "  |" + Environment.NewLine + "  |";

            Assert.Equal(attendu, représentation);
        }
        [Fact]
        public void Test2()
        {
            const uint chiffre = 2;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + " _|" + Environment.NewLine + " |_";

            Assert.Equal(attendu, repr);
        }

        [Fact]
        public void Test3()
        {
            const uint chiffre = 3;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + " _|" + Environment.NewLine + " _|";

            Assert.Equal(attendu, repr);
        }

        [Fact]
        public void Test4()
        {
            const uint chiffre = 4;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "   " + Environment.NewLine + "|_|" + Environment.NewLine + "  |";

            Assert.Equal(attendu, repr);
        }

        [Fact]
        public void Test5()
        {
            const uint chiffre = 5;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + " |_" + Environment.NewLine + " _|";

            Assert.Equal(attendu, repr);
        }
        [Fact]
        public void Test6()
        {
            const uint chiffre = 6;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + " |_" + Environment.NewLine + "|_|";

            Assert.Equal(attendu, repr);
        }

        [Fact]
        public void Test7()
        {
            const uint chiffre = 7;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + "  |" + Environment.NewLine + "  |";
            
            Assert.Equal(attendu, repr);
        }

        [Fact]
        public void Test8()
        {
            const uint chiffre = 8;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + "|_|" + Environment.NewLine + "|_|";

            Assert.Equal(attendu, repr);
        }

        [Fact]
        public void Test9()
        {
            const uint chiffre = 9;

            var repr = AfficheurNombres.Représenter(chiffre);

            var attendu = "  _" + Environment.NewLine + "|_|" + Environment.NewLine + " _|";

            Assert.Equal(attendu, repr);
        }
    }
}