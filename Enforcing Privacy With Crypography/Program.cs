using System.Runtime.ExceptionServices;

class Cryptography
{
    static void Main(string[] args)
    {
        int temp;   // varibale for swapping
        
        Console.Write("Enter Four Digit Number:  ");
        int num = Convert.ToInt32(Console.ReadLine());

        // encryption
        int digit1 = ((num / 1000) + 7) % 10;
        int digit2 = ((num % 1000) / 100 + 7) % 10;
        int digit3 = ((num % 100) / 10 + 7) % 10;
        int digit4 = ((num % 10) + 7) % 10;

        // swapping digit1 with digit3
        temp = digit1;
        digit1 = digit3;
        digit3 = temp;

        // swapping digit2 with digit4
        temp = digit2;
        digit2 = digit4;
        digit4 = temp;

        int encrypted = (digit1 * 1000) + (digit2 * 100) + (digit3 * 10) + digit4;

        Console.WriteLine();    // just for spacing purpose

        Console.WriteLine("Encrpyted Number: {0:D4}", encrypted);
    }
}
