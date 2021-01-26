using System;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isUser = false;
            Console.WriteLine("Registration...");
            Console.WriteLine("Please enter a username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter the password: ");
            string passwd = Console.ReadLine();
            Console.WriteLine("Now that the registration is finished, you may enter the credentials");

            Console.WriteLine("Username:");
            string newUname = Console.ReadLine();
            Console.WriteLine("Password:");
            string newpasswd = Console.ReadLine();
            if(userName == newUname && passwd == newpasswd)
            {
                isUser = true;
            }
            else
            {
                isUser = false;
            }
            Console.WriteLine(isUser);
        }
    }
}
