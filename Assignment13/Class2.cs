using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class CommonOptions
    {
        public static bool ChangePassword(User user, string newPassword)
        {
            // Implement password change logic
            if (user != null)
            {
                // Check if the new password meets your requirements (e.g., minimum length)
                if (newPassword.Length >= 8)
                {
                    user.Password = newPassword;
                    Console.WriteLine("Password changed successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Password should be at least 8 characters long.");
                }
            }
            else
            {
                Console.WriteLine("User not found.");
            }
            return false;
        }

        public static bool ViewProfile(User user)
        {
            // Implement logic to view and edit user profiles
            if (user != null)
            {
                Console.WriteLine("User Profile:");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Category: {user.Category}");

                // Add more profile information here

                Console.WriteLine("Do you want to edit your profile? (Y/N)");
                string input = Console.ReadLine();
                if (input.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    // Implement profile editing logic
                    Console.WriteLine("Editing user profile...");
                    // Update user's profile properties
                    // Example: user.Username = newUsername;
                    Console.WriteLine("Profile updated successfully.");
                    return true;
                }
                else if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("User not found.");
                return false;
            }
        }
    }
}
