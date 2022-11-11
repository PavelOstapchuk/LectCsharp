Console.WriteLine ("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "катя") // ToLower - переводит все в нижний регистр
{
    Console.WriteLine ("Привет любимая!");
}
else
{
    Console.WriteLine ("Привет, ");
    Console.WriteLine (username);
}