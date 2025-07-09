namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Add(3.3,5.2,false);
            Console.WriteLine(result);
        }

        private static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        private static double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        private static string Add(int numOne, int numTwo, bool isCash)
        {
            if (isCash)
            {
                int result = numOne + numTwo;
                return result != 1 ? $"{result} dollars" : $"{result} dollar";
            }
            else
            {
                return $"{numOne + numTwo}";
            }
        }
        private static string Add(double numOne, double numTwo, bool isCash)
        {
            if (isCash)
            {
                double result = numOne + numTwo;
                double resultCash = Math.Truncate(result);
                double decimalPart =  Math.Round(result - resultCash, 2);
                string resultString = $"{resultCash} dollars and {decimalPart} cents";
                return resultString;
            }
            else
            {
                return $"{numOne + numTwo}";
            }
        }
    }
}
