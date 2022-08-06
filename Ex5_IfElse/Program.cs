Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Даниил")
{
    Console.WriteLine("ohayo, oni-chan!");
}
else
{
    Console.Write("Привет, человек с именем ");
    Console.WriteLine(username);
}