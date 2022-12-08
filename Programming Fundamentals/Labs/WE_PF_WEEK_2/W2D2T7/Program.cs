//Bonus Task # 02
//Peak Element

using System;

namespace W2D2T7
{
    class PeakElement
    {
        public int[] A = { 5, 15, 100, 45, 55, 35 };

        public int ArrayPeakElement()
        {
            if (A.Length == 0)
                return 0;
            if (A.Length == 1)
                return A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (i == 0)
                {
                    if (A[0] >= A[1])
                        return A[0];
                }
                else if (i == A.Length - 1)
                {
                    if (A[A.Length - 1] >= A[A.Length - 2])
                        return A[A.Length - 1];
                }
                else
                {
                    if (A[i] >= A[i - 1] && A[i] >= A[i + 1])
                        return A[i];
                }
            }
            return 0;
        }
    }
    internal class Program
    {
        static void Main()
        {
            PeakElement x = new PeakElement();
            Console.WriteLine("Peak Element: " + x.ArrayPeakElement());

        }
    }
}
