using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Combinations
    {
        /* Complejidad del algoritmo Exponencial porque segun se cambie el valor el valor de n este se invoca nuevamente esas n veces, que es lo mismo que elever a la potencia de N  */

        private static int n = 40;
        public static long[] combinationsCache = new long[n + 1];

        static void Main(string[] args)
        {
            Combinations combinations = new Combinations();
            Console.WriteLine("# Ladder's steps: " + n);
            Console.WriteLine("# Step combinations: " + countcombinations(n, 0));
            Console.WriteLine("# Step combinations Dinamica: " + countCombinationsDinamica(n,0));
            Console.ReadLine();
        }

        public static long countCombinationsDinamica(int n, int level)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0 && level == 0)
            {
                return 0;
            }
            if (n == 0 && level > 0)
            {
                combinationsCache[n] = 1;
            }
            if (combinationsCache[n] == 0)
            {
                combinationsCache[n] = countCombinationsDinamica(n - 1, level + 1)+ countCombinationsDinamica(n - 2, level + 1) + countCombinationsDinamica(n - 3, level + 1);
            }
            return combinationsCache[n];
        }

        public static long countcombinations(int n, int level)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0 && level == 0)
            {
                return 0;
            }
            if (n == 0 && level > 0)
            {
                return 1;
            }
            return countcombinations(n - 1, level + 1) + countcombinations(n - 2, level + 1) + countcombinations(n - 3, level + 1);
        }

    }
}
