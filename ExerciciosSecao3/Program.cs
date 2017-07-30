using System;
using System.Globalization;

namespace ExerciciosSecao3
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo, alturaRetangulo, area, perimetro, diagonal;

            baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baseRetangulo * alturaRetangulo;
            perimetro = 2 * (baseRetangulo + alturaRetangulo);
            diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

            Console.WriteLine("AREA : " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO : " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL : " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
