Console.Write("Add ur name: ");
string username = Console.ReadLine();

if(username.ToLower() == "vladimir")
{
    Console.WriteLine("Herey, this is Vladimir!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}