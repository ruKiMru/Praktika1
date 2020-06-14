using System;

namespace Praktika1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Размер доски
            int size = 8;

            // Координаты начала
            int m, n;
            // Координаты конца
            int x, y;

            int u, v;

            var input = Console.ReadLine().Split(' ');

            m = int.Parse(input[0]);
            n = int.Parse(input[1]);
            x = int.Parse(input[2]);
            y = int.Parse(input[3]);


            if ((x + y) % 2 != (m + n) % 2 || m == x && n == y)
            {
                Console.WriteLine(0);
                return;
            }

            if ((x - y == m - n) || (x + y == m + n))
            {
                Console.WriteLine(1);
            }
            else
            {
                v = (x + y - m + n) / 2;
                u = x + y - v;

                bool isUContains = false;
                bool isVContains = false;

                for (int i = 1; i <= size; i++)
                {
                    if (u == i)
                    {
                        isUContains = true;
                    }
                    if (v == i)
                    {
                        isVContains = true;
                    }
                }

                if (!isUContains || !isVContains)
                {
                    v = (m + n - x + y) / 2;
                    u = x - y + v;
                }

                Console.WriteLine(2);
                Console.WriteLine(u + " " + v);
            }
        }
    }
}
