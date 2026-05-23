using System;

class KonwerterTemperatur
{
    static void Main()
    {
        Console.Write("Wybierz kierunek konwersji (C = Celsjusz→Fahrenheit, F = Fahrenheit→Celsjusz): ");
        string kierunek = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperaturę: ");
        double temp = double.Parse(Console.ReadLine());

        if (kierunek == "C")
        {
            double fahrenheit = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {fahrenheit}°F");
        }
        else if (kierunek == "F")
        {
            double celsius = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {celsius:F2}°C");
        }
        else
            Console.WriteLine("Nieprawidłowy kierunek konwersji.");
    }
}