Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура это маша");
}
else
{
    Console.WriteLine("Hi, ");
    Console.WriteLine(username);
}