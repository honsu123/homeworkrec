Console.WriteLine("Введите имя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА это же маша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}