using System.Globalization;
using Exercise1;

    Retangulo ret = new Retangulo();

    Console.WriteLine("Digite a Largura do Retangulo : ");
    ret.larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Digite a Altura do Retangulo");
    ret.alt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

