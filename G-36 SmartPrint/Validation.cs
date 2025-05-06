using System.Linq;
using System.Text.RegularExpressions;

namespace G_36_SmartPrint
{
    internal class Validation
    {
        // Email Validation
        public static bool IsValidEmail(string email)
        {
            // Basic email pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Password Validation

        public static bool IsValidPassword(string password)
        {
            // Must contain at least one letter and one number
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d).+$";
            return Regex.IsMatch(password, pattern);
        }


        // Name Validation: At least 2 words
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            string[] parts = name.Trim().Split(' ');
            return parts.Length >= 2 && parts.All(p => p.Length > 0);

        }





    }
}