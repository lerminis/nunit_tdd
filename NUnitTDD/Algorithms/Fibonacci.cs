namespace NUnitTDD.Algorithms
{
    public class Fibonacci
    {
        public static int GetOutput(int number)
        {
            if (number < 2) return number;

            return GetOutput(number - 1) + GetOutput(number - 2);
        }
    }
}