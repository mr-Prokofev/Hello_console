Console.WriteLine("Введите имя пользователя: ");
string u_name = Console.ReadLine();
if (u_name.ToLower() == "artem")
{
    Console.WriteLine("Yes, my Lord!");
}
else
{
    Console.Write("Buy!");
    Console.WriteLine(u_name);
}
