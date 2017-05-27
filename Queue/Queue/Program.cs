using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Bod> que = new Queue<Bod>();
            int[,] plocha = new int[,]
            {
                {-1 ,-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                {-1 ,-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
                {-1 ,-1,  0,  0,  0,  0,  0,  0,  0,  0, -1, -1 },
                {-1 ,-1,  0,  0,  0,  0,  0,  0, -2,  0, -1, -1 },
                {-1 ,-1,  0,  0,  0,  0,  0,  0,  0,  0, -1, -1 },
                {-1 ,-1,  0,  0,  0,  0,  0,  0,  0,  0, -1, -1 },
                {-1 ,-1, -2,  0,  0,  0,  0,  0,  0,  0, -1, -1 },
                {-1 ,-1, -1, -1, -1,- 1, -1, -1, -1, -1, -1, -1 },
                {-1 ,-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 }
            };
            Bod a = new Bod(2, 6, 0);
            que.Enqueue(a);
            while (true)
            {
                Bod b = que.Dequeue();
                    if (plocha[b.X + 1, b.Y] == 0)
                    {
                        plocha[b.X + 1, b.Y] = b.cislo + 1;
                        que.Enqueue(new Bod(b.X + 1, b.Y, b.cislo + 1));
                    }
                    if (plocha[b.X - 1, b.Y] == 0)
                    {
                        plocha[b.X - 1, b.Y] = b.cislo + 1;
                        que.Enqueue(new Bod(b.X - 1, b.Y, b.cislo + 1));
                    }
                    if (plocha[b.X, b.Y + 1] == 0)
                    {
                        plocha[b.X, b.Y + 1] = b.cislo + 1;
                        que.Enqueue(new Bod(b.X, b.Y - 1, b.cislo + 1));
                    }
                   if (plocha[b.X, b.Y - 1] == 0)
                    {
                        plocha[b.X, b.Y - 1] = b.cislo + 1;
                        que.Enqueue(new Bod(b.X, b.Y - 1, b.cislo + 1));
                    }
                if (que.Count == 0)
                    break;
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j =0; j<12; j++)
                {
                        Console.Write(plocha[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
