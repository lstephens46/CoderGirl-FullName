using System;

namespace FullName
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Please enter your first name:  ");
            string firstName = Console.ReadLine();
            // TODO: Ask the user for their first name and then their last name.
            Console.Write("Please enter your last name:  ");
            string lastName = Console.ReadLine();
            // TODO: Call a method called FullName that returns their full name.
            //FullName(firstName, lastName);
            Console.WriteLine(FullName(firstName, lastName));

            // TODO: Output their full name.

            Console.ReadLine();
        }

        public static string FullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
        // TODO: Create a method call FullName that takes the firstName and lastName as parameters.
    }
}
