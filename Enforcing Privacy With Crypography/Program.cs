class Cryptography
{
    static void Main(string[] args)
    {
        Console.Write("Enter Four Digit Number:  ");
        int num = Convert.ToInt32(Console.ReadLine());

        // encryption
        int digit1 = ((num / 1000) + 7) % 10;
        int digit2 = ((num % 1000) / 100 + 7) % 10;
        int digit3 = ((num % 100) / 10 + 7) % 10;
        int digit4 = ((num % 10) + 7) % 10;

        int encrypted = (digit1 * 1000) + (digit2 * 100) + (digit3 * 10) + digit4;

        Console.WriteLine();    // just for spacing purpose

        Console.WriteLine("Encrpyted Number: {0:D4}", encrypted);
    }
}
