using System.Runtime.ExceptionServices;

class Cryptography
{
    static void Main(string[] args)
    {
        int temp;   // varibale for swapping
        
        // taking a four digit number from user
        Console.Write("Enter Four Digit Number:  ");
        int num = Convert.ToInt32(Console.ReadLine());

        // encryption
        int digit1 = ((num / 1000) + 7) % 10;
        int digit2 = (((num % 1000) / 100) + 7) % 10;
        int digit3 = (((num % 100) / 10) + 7) % 10;
        int digit4 = ((num % 10) + 7) % 10;

        // swapping digit1 with digit3
        temp = digit1;
        digit1 = digit3;
        digit3 = temp;

        // swapping digit2 with digit4
        temp = digit2;
        digit2 = digit4;
        digit4 = temp;

        // combining digits to again make a four digit number
        int encrypted = (digit1 * 1000) + (digit2 * 100) + (digit3 * 10) + digit4;

        Console.WriteLine();    // just for spacing purpose

        // displaying encrypted number
        Console.WriteLine("Encrpyted Number: {0:D4}", encrypted);

        // decryption
        digit1 = ((encrypted / 1000) + 3) % 10;
        digit2 = (((encrypted % 1000) / 100) + 3) % 10;
        digit3 = (((encrypted % 100) / 10) + 3) % 10;
        digit4 = ((encrypted % 10) + 3) % 10;

        // swapping digit1 with digit3
        temp = digit1;
        digit1 = digit3;
        digit3 = temp;

        // swapping digit2 with digit4
        temp = digit2;
        digit2 = digit4;
        digit4 = temp;

        // combining digits to again make a four digit number
        int decryption = (digit1 * 1000) + (digit2 * 100) + (digit3 * 10) + digit4;

        Console.WriteLine("Decrypted Number: {0:D4}", decryption);
    }
}
