public class Solution 
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] digits = { 9, 9 };
            int[] check = solution.PlusOne(digits);

            foreach (int i in check)
            {
                Console.WriteLine(i);
            }
        }
    }

    public int[] PlusOne(int[] digits) 
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i]++;

            if (digits[i] < 10)
            {
                return digits;
            }

            digits[i] = 0; 
        }

        // Создаём новый массив, если все цифры были 9
        int[] newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;

        return newDigits;   
    }
}
