//Mars Exploration - SOS

using System;

namespace W1D2T1
{
    internal class Program
    {
        public static int MarsExploration(string sos)
        {
            int changedLetters = 0;

            for (int i = 0; i < sos.Length; i += 3)
            {
                if (sos[i] != 'S')
                    changedLetters++;
                if (sos[i + 1] != 'O')
                    changedLetters++;
                if (sos[i + 2] != 'S')
                    changedLetters++;
            }
            return changedLetters;
        }
        static void Main()
        {
            string sos = "SOSTOT";
            Console.WriteLine("No of letters changed during transmission: {0}", MarsExploration(sos));
        }
    }
}
