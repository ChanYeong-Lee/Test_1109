using System.Runtime.CompilerServices;

namespace Test_3
{
    internal class Program
    {
        static bool IsPrime(int n)  // 소수의 정의 : 1과 자신 외에 나눠지는 수가 없다.
        {
            if (n == 1)
                return false;
            for (int i = 2; i<= Math.Sqrt(n);i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int iValue;
            int.TryParse(str, out iValue);
            if (IsPrime(iValue))
                Console.WriteLine("{0}은 소수입니다.", iValue);
            else
                Console.WriteLine("{0}은 소수가 아닙니다.", iValue);

        }
    }
}