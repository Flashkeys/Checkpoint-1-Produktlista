// regex om jag vill
// program.cs via private chatt eller github

List<string> produkt = new List<string>();

Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'.");

while (true)
{
    Console.ResetColor();
    string checkInput = Console.ReadLine().Trim();

    //check if input is empty
    if (string.IsNullOrWhiteSpace(checkInput))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("not correct input");
        continue;
    }

    //check if input is exit
    if (checkInput.ToLower() == "exit")
    {
        break;
    }

    string[] segments = checkInput.Split("-");

    // check if there are two segments
    if (segments.Length != 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("not correct input");
        continue;
    }

    // check if segments are empty
    if (segments.Any(string.IsNullOrWhiteSpace))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("not correct input");
        continue;
    }

    string name = segments[0].Trim();
    string number = segments[1].Trim();

    //check if name is all uppercase
    if (name != name.ToUpper())
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("not correct input");
        continue;
    }

    //check if number is all digits
    if (!number.All(char.IsDigit))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("not correct input");
        continue;
    }

    produkt.Add(checkInput);
    
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Du angvan följande produkter:");
produkt.Sort();
foreach (var value in produkt)
{
    Console.WriteLine(value);
}
Console.ResetColor();