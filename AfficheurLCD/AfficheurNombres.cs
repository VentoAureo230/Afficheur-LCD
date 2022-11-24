namespace AfficheurLCD
{
    public class AfficheurNombres
    {
        public static string Représenter(uint chiffre)
        {
            switch (chiffre)
            {
                case 1:
                    return ("   " + Environment.NewLine + "  |" + Environment.NewLine + "  |");
                case 2:
                    return ("  _" + Environment.NewLine + " _|" + Environment.NewLine + " |_");
                case 3:
                    return ("  _" + Environment.NewLine + " _|" + Environment.NewLine + " _|");
                case 4:
                    return ("   " + Environment.NewLine + "|_|" + Environment.NewLine + "  |");
                case 5:
                    return ("  _" + Environment.NewLine + " |_" + Environment.NewLine + " _|");
                case 6:
                    return ("  _" + Environment.NewLine + " |_" + Environment.NewLine + "|_|");
                case 7:
                    return ("  _" + Environment.NewLine + "  |" + Environment.NewLine + "  |");
                case 8:
                    return ("  _" + Environment.NewLine + "|_|" + Environment.NewLine + "|_|");
                case 9:
                    return ("  _" + Environment.NewLine + "|_|" + Environment.NewLine + " _|");
                default:
                    return ("  _" + Environment.NewLine + "| |" + Environment.NewLine + "|_|");
            }
        }
    }
}