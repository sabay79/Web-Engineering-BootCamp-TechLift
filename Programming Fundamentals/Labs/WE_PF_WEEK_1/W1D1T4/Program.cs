//Strong Password

using System;
using System.Linq;

namespace W1D1T4
{
    internal class Program
    {
        static int MinimumNumber(int n, string password)
        {
            var numbers = "0123456789";
            var lowerCase = "abcdefghijklmnopqrstuvwxyz";
            var upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var specialCharacters = "!@#$%^&*()-+";

            bool num = false, lc = false, uc = false, sc = false;

            for (int i = 0; i < n; i++)
            {
                if (numbers.Contains(password[i])) num = true;
                if (lowerCase.Contains(password[i])) lc = true;
                if (upperCase.Contains(password[i])) uc = true;
                if (specialCharacters.Contains(password[i])) sc = true;

            }

            int count = 0;
            if (num == false) count++;
            if (lc == false) count++;
            if (uc == false) count++;
            if (sc == false) count++;

            if (n + count > 6)
                return count;
            else
                return count + (6 - count - password.Length);
        }
        static void Main()
        {
            string password = "Saba7222";
            int n = password.Length;

            int ans = MinimumNumber(n, password);

            if (ans == 0)
                Console.WriteLine("Strong Password\n");
            else
            {
                Console.WriteLine("Password is not Strong.\n" +
                "\n------------------------------------" +
                "\nYour password must have atleast:" +
                "\n- 6 characters" +
                "\n- One digit" +
                "\n- A lowercase English character" +
                "\n- An uppercase English character" +
                "\n- One special character !@#$%^&*()-+" +
                "\n------------------------------------" +
                "\n\nYou need to add {0} more character(s).\n", ans);
            }
        }
    }
}
