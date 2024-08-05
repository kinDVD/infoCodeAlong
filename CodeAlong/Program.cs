
/* Project Info Collector
 * 
 * Get user personal info
 * if 18+ CW "Haha took your banking info"
 * if not CW "Don't give out your personal info"
 */

Console.WriteLine("Welcome to InfoCollector");
Console.WriteLine();

//collecting info
Console.WriteLine("Please type out your name");
string name = Console.ReadLine();

Console.WriteLine();

//Console.WriteLine("What is your age" + name);
Console.WriteLine($"Hell0 {name}, what is your age?");
int age = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"{name}, what is your hometown?");
string hometown = Console.ReadLine();

Console.WriteLine();

//Display result
if (age >= 18)
{
    Console.WriteLine($"HAHA {name}! I am going to take your account that is in {hometown}!");
}
else
{
    Console.WriteLine("Don't give out your info, bro...");
}