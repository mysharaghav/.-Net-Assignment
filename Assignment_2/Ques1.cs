using System;

namespace Assignment_2
{
    internal class Ques1
    {
        class UserProfile
        {
            private string username;
            private string password;
            private string email;

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string Password
            {
                get { return password; }
                set
                {
                    if (value.Length >= 6)
                        password = value;
                    else
                        Console.WriteLine("Password must be at least 6 characters long.");
                }
            }

            public string Email
            {
                get { return email; }
                set
                {
                    if (value.Contains("@"))
                        email = value;
                    else
                        Console.WriteLine("Invalid email format.");
                }
            }

            public void Display()
            {
                Console.WriteLine($"Username: {username}, Email: {email}");
            }
        }

        static void Main(string[] args)
        {
            UserProfile user1 = new UserProfile();
            user1.Username = "Utkarsh";
            user1.Password = "secure123";
            user1.Email = "utkarsh@example.com";

            UserProfile user2 = new UserProfile();
            user2.Username = "Raj";
            user2.Password = "pass";
            user2.Email = "raexample.com";

            user1.Display();
            user2.Display();
            Console.WriteLine("Developed By Utkarsh Roll-48");
        }
    }
}
