using System;

namespace FindHolger
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Find Holger
            Der skal laves et program der kan udskrive 40 rækker med 40 tilfældige bogstaver i hver række
            Ét af bogstaverne skal erstattes med et @
            Spillet handler om at finde @’et

            Udvidelser til ekstra udfordring:
            -	Prøv at lege med om det er store eller små bogstaver der skrives
            -	Prøv at skifte farve på bogstaverne
            -	Prøv at lave en måde hvor man kan indtaste en løsning (måske med koordinater)
            */

            // Laver en liste af små bogstaver fra a-z så vi har afgrænsningen for de characters vi må bruge
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // Opretter en pseudo random number generator (PRNG)
            Random ran = new Random();

            // Definerer antal rækker samt kolonner
            int rows = 40, cols = 40;

            // PRNG af række og kolonne for at bestemme @'s koordinat
            int targetRow = ran.Next(rows);
            int targetCol = ran.Next(cols);

            // går igennm række en efter en. På den måde "besøger" programmet alle celler i matricen
            for (int row =  0; row < rows; row++)
            {
            // går igennm kolonne en efter en. På den måde "besøger" programmet alle celler i matricen
                for (int col = 0; col < cols; col++)
                {
                    /* en tilfældig række og en tilfædig kolonne er valgt tidligere frat PRNG.
                     * hvis vi er på den "udvalgte" celle med de specifikke koordinater, udskrives @
                     * hvis ikke, udskrives et tilfædigt lille bogstav fra a-z.*/
                     
                    if (row == targetRow && col == targetCol)
                    {
                        Console.Write('@');
                    }
                    else
                    {
                        Console.Write(letters[ran.Next(letters.Length)]);
                    }
                    // bogstaverne får en farve baseret på tilfædighed. Sort er udeladt (0), så man kan se udskriften da background også er sort
                    Console.ForegroundColor = (ConsoleColor)ran.Next(1, 16);
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}
