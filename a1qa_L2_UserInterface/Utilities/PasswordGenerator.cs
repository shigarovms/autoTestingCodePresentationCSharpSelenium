using System.Text;
using System.Text.RegularExpressions;

namespace a1qa_L2_UserInterface.Utilities
{
    internal static class PasswordGenerator
    {
        private const string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string numerals = "0123456789";
        private const string cyrillicLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private const int ASCIIRangeStart = 33;
        private const int ASCIIRangeEnd = 126;
        private static int passwordLength = Tests.Test.testData.GetValue<int>("TC0001_AllThreeCardsAreReachable.passwordLength");
        public static string GeneratePassword()
        {
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
                char randomChar = (char)new Random().Next(ASCIIRangeStart, ASCIIRangeEnd); // ASCII range of printable characters
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
