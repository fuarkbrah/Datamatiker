using System.Numerics;

double num1 = 0;
        double num2 = 0;
        double result = 0;

        Console.WriteLine("----------");
        Console.WriteLine("Lommeregner Program");
        Console.WriteLine("----------");

        Console.Write("Enter number 1: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an option");
        Console.WriteLine("\t+; Add");
        Console.WriteLine("\t- : Subtract");
        Console.WriteLine("\t * ; Multiplication");
        Console.WriteLine("\t / ; Divide");

string operation = Console.ReadLine();
double sum = 0;

if (operation == "+")
{
    sum = num1 + num2;
}
else if (operation == "-")
{
    sum = num1 - num2;

}
else if (operation == "*")
{
    sum = num1 * num2;

}
else if (operation == "/")
{
    sum = num1 / num2;
    if (num1 == 0) //0/0
    {
        Console.WriteLine("Fejl: Divison med 0/0 er ikke tilladt.");
    }
    else // division med 0
    {
        Console.WriteLine("Fejl: Division med nul (0) er ikke tilladt");
    }
    return; //afslut programmet
} 
Console.WriteLine(" Resultat = " + sum);



