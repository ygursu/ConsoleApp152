using System;

namespace EnSikKullanilanEleman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizi uzunlugunu giriniz: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dizinin {i + 1}. elemanini giriniz: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int mostCommonElement = arr[0];
            int currentElement = arr[0];
            int currentFrequency = 1;
            int maxFrequency = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == currentElement)
                {
                    currentFrequency++;
                }
                else
                {
                    currentElement = arr[i];
                    currentFrequency = 1;
                }

                if (currentFrequency > maxFrequency)
                {
                    maxFrequency = currentFrequency;
                    mostCommonElement = currentElement;
                }
            }

            Console.WriteLine($"En cok kullanilan eleman: {mostCommonElement}");
            Console.WriteLine($"Tekrar sayisi: {maxFrequency}");
        }
    }
}