using System;
class Program
{
    static void Main()
    {
        // Number entry from user
        Console.Write("Faktöriyelini hesaplamak istediğiniz sayıyı girin: ");
        string giris = Console.ReadLine();

        // string to int conversion
        int sayi;
        if (int.TryParse(giris, out sayi) && sayi >= 0) // Negative number control
        {
            long faktoriyel = 1;

            // Factorial calculation
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }

            // Print the result
            Console.WriteLine($"{sayi}! = {faktoriyel}");
        }
        else
        {
            Console.WriteLine("Geçerli bir pozitif sayı girin.");
        }
    }
}