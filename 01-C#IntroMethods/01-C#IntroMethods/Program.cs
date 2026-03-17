//1
class Program
{
    static void TekCut(int[] ededler)
    {
        for (int i = 0; i < ededler.Length; i++)
        {
            if (ededler[i] % 2 == 0)
                Console.WriteLine(ededler[i] + " cut");
            else
                Console.WriteLine(ededler[i] + " tek");
        }
    }

    static void Main()
    {
        int[] arr = { 14, 20, 35, 40, 57, 60, 100 };
        TekCut(arr);
    }
}

//4
using System;

class Program
{
    static void Main()
    {
        Console.Write("Cumleni daxil et: ");
        string cumle = Console.ReadLine();

        Console.Write("Simvolu daxil et: ");
        char simvol = Convert.ToChar(Console.ReadLine());

        int say = 0;

        for (int i = 0; i < cumle.Length; i++)
        {
            if (cumle[i] == simvol)
            {
                say++;
            }
        }

        Console.WriteLine("Simvolun sayi: " + say);
    }
}


//3
class Program
{
    static int Bolunen(int[] arr)
    {
        int cem = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 4 == 0 && arr[i] % 5 == 0)
            {
                cem += arr[i];
            }
        }

        return cem;
    }

    static void Main()
    {
        int[] ededler = { 14, 20, 35, 40, 57, 60, 100 };
        Console.WriteLine(Bolunen(ededler));
    }
}
