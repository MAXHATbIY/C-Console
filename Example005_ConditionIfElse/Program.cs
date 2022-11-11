Console.Write("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "слава")
{
    Console.WriteLine("Ура, это же Слава");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}