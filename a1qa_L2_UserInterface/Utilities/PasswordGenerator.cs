using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace a1qa_L2_UserInterface.Utilities
{
    internal class PasswordGenerator
    {
        public static string GeneratePassword()
        {
            const int passwordLength = 10;
            const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numerals = "0123456789";
            const string cyrillicLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            StringBuilder passwordBuilder = new StringBuilder(passwordLength);

            // Add a random capital letter
            passwordBuilder.Append(capitalLetters[new Random().Next(capitalLetters.Length)]);

            // Add a random numeral
            passwordBuilder.Append(numerals[new Random().Next(numerals.Length)]);

            // Add a random cyrillic character
            passwordBuilder.Append(cyrillicLetters[new Random().Next(cyrillicLetters.Length)]);

            // Add random characters until the password length is met
            while (passwordBuilder.Length < passwordLength)
            {
                char randomChar = (char)new Random().Next(33, 126); // ASCII range of printable characters
                passwordBuilder.Append(randomChar);
            }

            string password = passwordBuilder.ToString();

            // Ensure that the password meets the requirements
            if (password.Length < passwordLength || !Regex.IsMatch(password, "[A-Z]") || !Regex.IsMatch(password, @"\d") || !Regex.IsMatch(password, "[а-яёА-ЯЁ]"))
            {
                return GeneratePassword(); // Recursively generate a new password until it meets the requirements
            }

            return password;
        }
    }
}
