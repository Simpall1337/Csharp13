using System;
namespace Lessons
{
    internal class Program
    {
        static void SumNumber(ref int Number, ref int KeepNumber, int i = 0)
        {
            if (i == 100)
                return;
            KeepNumber = KeepNumber + Number % 10;
            Number = Number / 10;
            i++;
            SumNumber(ref Number, ref KeepNumber, i);
        }
        static void Main(string[] args)
        {
            int KeepNumber = 0;
            int Number = 1234567890;
            SumNumber(ref Number, ref KeepNumber);
            Console.WriteLine(KeepNumber);
        }
    }
}
