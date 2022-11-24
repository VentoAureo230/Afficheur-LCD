using AfficheurLCD;

var nombreSaisi = uint.Parse(Console.ReadLine() ?? string.Empty);
Console.WriteLine(AfficheurNombres.Représenter(nombreSaisi));
