using System;

class Program
{
    static void Main()
    {
        string chars = "qwertyuiopasdfghjklzxcvbnm1234567890@#$_&-+()/*':!?";
        Random numbs = new Random();
        string password = "";

        for (int i = 0; i < 8; i++)
        {
            password += chars[numbs.Next(chars.Length)];
        }
        Console.WriteLine($"Your password:\n{password}");
    }
}