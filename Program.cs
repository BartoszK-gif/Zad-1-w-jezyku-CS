using System;

class Kalkulator
{
    static void Main()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj operację (+, -, *, /): ");
        string op = Console.ReadLine();

        if (op == "+")
            Console.WriteLine($"Wynik: {a + b}");
        else if (op == "-")
            Console.WriteLine($"Wynik: {a - b}");
        else if (op == "*")
            Console.WriteLine($"Wynik: {a * b}");
        else if (op == "/")
        {
            if (b == 0)
                Console.WriteLine("Błąd: dzielenie przez zero.");
            else
                Console.WriteLine($"Wynik: {a / b}");
        }
        else
            Console.WriteLine("Nieznana operacja.");
    }
}