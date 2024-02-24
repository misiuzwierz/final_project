using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Witaj w grze Quiz o stolicach świata!");

        // Pobieranie liczby graczy
        Console.Write("Podaj liczbę graczy: ");
        int liczbaGraczy = int.Parse(Console.ReadLine());

        // Inicjalizacja tablicy wyników
        int[] wyniki = new int[liczbaGraczy];

        // Pętla główna gry
        bool koniecGry = false;
        while (!koniecGry)
        {
            // Losowanie pytania
            string[] pytania = { "Jaka jest stolica Polski?", "Jaka jest stolica Francji?", "Jaka jest stolica Japonii?" };
            string[] odpowiedzi = { "Warszawa", "Paryż", "Tokio" };
            Random random = new Random();
            int index = random.Next(pytania.Length);

            // Wyświetlanie pytania
            Console.WriteLine("Pytanie dla wszystkich graczy:");
            Console.WriteLine(pytania[index]);

            // Pobieranie odpowiedzi od każdego gracza
            for (int i = 0; i < liczbaGraczy; i++)
            {
                Console.Write($"Gracz {i + 1}, podaj odpowiedź: ");
                string odpowiedz = Console.ReadLine();

                // Sprawdzanie poprawności odpowiedzi
                if (odpowiedz.Equals(odpowiedzi[index], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Poprawna odpowiedź!");
                    wyniki[i]++;
                }
                else
                {
                    Console.WriteLine("Niepoprawna odpowiedź.");
                }
            }

            // Sprawdzenie czy kontynuować grę
            Console.Write("Czy chcesz zagrać ponownie? (t/n): ");
            char odpowiedzGracza = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (odpowiedzGracza != 't')
            {
                koniecGry = true;
            }
        }

        // Wyświetlanie wyników końcowych
        Console.WriteLine("Wyniki końcowe:");
        for (int i = 0; i < liczbaGraczy; i++)
        {
            Console.WriteLine($"Gracz {i + 1}: {wyniki[i]} punktów");
        }
    }
}
