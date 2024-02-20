using System;

namespace PasswordGenerator
{
    using System;

    class PasswordGenerator
    {
        //this main method asks for user input and acts based on it
        static void Main()
        {   
            //Informs the user what the program does and asks them to enter a length for the password
            Console.WriteLine("Creates a random password with uppercase and lowercase letters, numbers and symbols.");
            Console.WriteLine("Strong passwords are at least 12 characters long");
            Console.Write("Enter the length of the password: ");

            //adds a boolean to keep the user in the program in case they make a wrong input
            bool isValid = false;

            //keeps the user in the loop until the 'isValid' boolean becomes true
            do
            {
                //reads the user input and parses it into an integer, storing it in the variable 'passwordLength'
                if (int.TryParse(Console.ReadLine(), out int passwordLength))
                {
                    //calls the 'GenerateRandomPassword' method with the users password length and stores the result in the 'password' variable
                    string password = GenerateRandomPassword(passwordLength);
                    //shows the user the randomized password
                    Console.WriteLine($"Generated Password: {password}");
                    //breaks the user out of the loop
                    isValid = true;
                }
                else
                {
                    //if the user input can't be parsed as an integer they get an error
                    Console.WriteLine("Invalid input. Please enter a valid number for the password length.");
                    //keeps the user in the loop
                    isValid = false;
                }
            } while (!isValid);
            
        }
        //this method generates the random password for the user
        static string GenerateRandomPassword(int maxLength)
        {
            //this is a constant string that contains all the possible characters in the password
            const string allCharacters = "QWERTYUIOPÅASDFGHJKLÖÄZXCVBNMqwertyuiopåasdfghjklöäzxcvbnm0123456789!@#$%^&*()-_=+[]{}|;:'\",.<>/?";

            //creates an array to store the characters
            char[] passwordArray = new char[maxLength];
            //initializes a 'Random' class which will generate the random password
            Random random = new Random();

            //a loop that will fill the 'passwordArray' with random characters up to the chosen length
            for (int length = 0; length < maxLength; length++)
            {
                //generates a random index within the range of 'allCharacters' length
                int randomIndex = random.Next(allCharacters.Length);
                //assigns random characters from 'allCharacters' to the 'passwordArray'
                //the random character is chosen based on the generated 'randomIndex'
                passwordArray[length] = allCharacters[randomIndex];
            }
            //converts the character array to a string and returns the result
            return new string(passwordArray);
        }

    }
    
}

