using Humanizer;

Console.Clear();
Console.WriteLine("");

Console.WriteLine("Quantities:");
HumanizeQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

Console.Write("\nPress any key to exit...");
Console.ReadKey();
Console.WriteLine("\nBye Bye...");
Thread.Sleep(2000);
Console.Clear();


static void HumanizeQuantities()
{
    // Exibe a quantidade 0 com a forma plural de "case"
    Console.WriteLine("case".ToQuantity(0));
    
    // Exibe a quantidade 1 com a forma singular de "case"
    Console.WriteLine("case".ToQuantity(1));
    
    // Exibe a quantidade 5 com a forma plural de "case"
    Console.WriteLine("case".ToQuantity(5));
}


static void HumanizeDates()
{
    // Exibe a data e hora de 24 horas atrás em um formato legível para humanos
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());

    // Exibe a data e hora de 2 horas atrás em um formato legível para humanos
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());

    // Converte um intervalo de tempo de 1 dia em uma string legível
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());

    // Converte um intervalo de tempo de 16 dias em uma string legível
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}
