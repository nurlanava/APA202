using System;
using System.Runtime.Serialization.Formatters;
class Porgram
{
static int[] ArrayResize(int[] numbers,params int[] values)
    {
        Array.Resize(ref numbers, numbers.Length,params int[] values);
        for(int i=0; i<numbers.Length; i++ )    
        {
            numbers[numbers.Length-values.Length +i] = values[i];
    }
        return numbers;
        static void Main()
        {
            int[] numbers = { 5, 6, 7 };
            numbers=ArrayResize(numbers, 8,9);
            For(int i = 0;int<numbers.Length;int++)
                {
                Console.WriteLine(numbers[i]+" ");
            }
        }