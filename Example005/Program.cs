Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "masha")
{
    Console.WriteLine("Yea, it's Masha");
}
else 
{
    Console.WriteLine("Hello, " + username);
}
