using System;
class Program
{
    static void Toplama(int a, int b)
    {
        int netice = a + b;
        Console.WriteLine("Cem:" + netice);
        if (netice % 2 == 0)
            Console.WriteLine("Netice cutdur");
        else Console.WriteLine("Netice tekdir");
    }
    static void Cixma(int a, int b)
    {
        int netice = a - b;
        Console.WriteLine("Ferq:" + netice);
        if (netice % 2 == 0)
            Console.WriteLine("Netice cutdur");
        else
            Console.WriteLine("Netice tekdir");
    }
    static void Vurma(int a, int b)
    {
        int netice = a * b;
        Console.WriteLine("Hasil:" + netice);
        if (netice % 2 == 0)
            Console.WriteLine("Netice cutdur");
        else
            Console.WriteLine("Netice tekdir");
    }
    static void Bolme(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("0-a bolmek olmaz");
            return;
        }
        double netice = (double)a / b;
        Console.WriteLine("BOlme:" + netice);
        if ((int)netice % 2 == 0)
            Console.WriteLine("Netice cutdur");
        else
            Console.WriteLine("Netice tekdir");
    }
    static void Main()
    {
        Toplama(1, 2);
        Cixma(3, 4);
        Vurma(6, 5);
        Bolme(7, 8);
    }
}