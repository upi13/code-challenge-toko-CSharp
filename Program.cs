using System;
using System.Linq;

namespace Latihan
{
    class Program
    {
    	public static void Main (string[]args)
    	{
    	string username;
    	string password;
    	do
    	{
        Console.Write("\nMasukan Username : ");
        username = Console.ReadLine();
        Console.Write("Masukan Password : ");
        password = Console.ReadLine();
    	}
    	while(username != "admin" && password != "admin");
    	Home login = new Home();
    	login.home();
    	}
    }
}