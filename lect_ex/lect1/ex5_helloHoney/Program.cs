// give hello to special user or just hi to another
Console.WriteLine("Your name is?");
string username = Console.ReadLine();
if (username.ToLower() == "Ivan")
    Console.WriteLine("Hello my sweety, " + username);
    else
    {
        Console.WriteLine("hi, " + username);
    }
