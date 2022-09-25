using System;

namespace QuichShort
{
    class Program
    {
        private int[] arr = new int[20];
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Masukan panjang element array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nMaksimum panjang array adalah 20");
            }
            Console.WriteLine("\n------------------)");
            Console.WriteLine("\nEnter Array Element)");
            Console.WriteLine("\n------------------)");

            for(int i=0; i<n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
