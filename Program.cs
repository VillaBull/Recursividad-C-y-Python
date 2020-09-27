using System;

namespace parcial_2_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("introduzca un numero");
            num = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine($"la suma es: {suma(num)}");
            Console.ReadKey();
        }
        public static long suma(int n)
        {
                if (n == 1){
                    return 1;
                 }
                else
                {
                    return n + suma(n-1);
                }
            
        }
    }
}
