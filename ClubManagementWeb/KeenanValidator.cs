using System.Text.RegularExpressions;

namespace ClubManagementWeb
{
    public static class KeenanValidator
    {
        public static bool IsValidEmail(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return Regex.IsMatch(input, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsValidPhone(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return Regex.IsMatch(input, @"^(\(\d{3}\)\s?|\d{3}[- ]?)\d{3}[- ]?\d{4}$");
        }

        public static bool IsValidZip(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return Regex.IsMatch(input, @"^\d{5}(-\d{4})?$");
        }

        public static bool IsStrongPassword(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return false;
            return Regex.IsMatch(input, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z\d]).{8,}$");
        }

        public static string GetValidationMessage(string input, string type)
        {
            switch ((type ?? "").ToLower())
            {
                case "email":
                    return IsValidEmail(input) ? "Valid email." : "Invalid email.";
                case "phone":
                    return IsValidPhone(input) ? "Valid phone number." : "Invalid phone number.";
                case "zip":
                    return IsValidZip(input) ? "Valid ZIP code." : "Invalid ZIP code.";
                case "password":
                    return IsStrongPassword(input) ? "Strong password." : "Password must be at least 8 characters and include uppercase, lowercase, a number, and a special character.";
                default:
                    return "Unknown validation type.";
            }
        }
    }
}