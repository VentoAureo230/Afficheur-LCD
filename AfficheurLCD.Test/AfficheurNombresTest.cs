namespace AfficheurLCD.Test
{
    public class AfficheurNombresTest
    {
        public static readonly object[][] Associations = new []
        {
            new object[] { 0, Digits.Zero },
            new object[] { 1, Digits.One },
            new object[] { 2, Digits.Two },
            new object[] { 3, Digits.Three },
            new object[] { 4, Digits.Four },
            new object[] { 5, Digits.Five },
            new object[] { 6, Digits.Six },
            new object[] { 7, Digits.Seven },
            new object[] { 8, Digits.Eight },
            new object[] { 9, Digits.Nine }
        };

        [Theory]
        [MemberData(nameof(Associations))]
        public void TestChiffreUnique(int chiffre, string representation)
        {
            // ETANT DONNE le chiffre <chiffre>
            // QUAND on le convertit en LCD
            var lcd = new AfficheurLCD.Convert(chiffre);

            // ALORS on obtient sa représentation LCD
            Assert.Equal(representation, lcd);
        }

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
