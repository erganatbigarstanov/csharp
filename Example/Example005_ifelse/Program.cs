Console.Write("ведитее имя аользователя :");
string username = Console.ReadLine();

if ( username.ToLower() == "маша")
{
    Console.WriteLine("ура это Маша");
}
else
{
    Console.Write("привет");
    Console.WriteLine(username);
}