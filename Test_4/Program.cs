namespace Test_4
{
    internal class Program
    {

        static int SumOfDigits(int num)
        {
            int sum = 0;
            string str = num.ToString();
            for(int i =0;i< str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigits(int.Parse(Console.ReadLine())));
        }
    }
}