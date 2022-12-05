using AfficheurLCD;

while (true)
{
    var nombreSaisi = uint.Parse(Console.ReadLine() ?? string.Empty);
    Console.WriteLine(AfficheurNombres.Représenter(nombreSaisi));
}

