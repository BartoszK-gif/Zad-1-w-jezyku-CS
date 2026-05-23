using System;

class SredniaOcen
{
    static void Main()
    {
        Console.Write("Podaj liczbę ocen: ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ocena {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");
        Console.WriteLine(srednia >= 3.0 ? "Uczeń zdał." : "Uczeń nie zdał.");
    }
}
