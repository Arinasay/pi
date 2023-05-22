using System;

namespace montecarlo
{
    internal class Program
    {
        static void VicPi()
        {
            Random random = new Random();
            int n = 10000;
            int r = 1; 
            double x, y; 
            double S0 = Math.Pow(2 * r, 2);
            int k = 0; 
            for (int i = 0; i < n; i++)
            {
                x = random.NextDouble() * (0 - 2 * r) + 2 * r;
                y = random.NextDouble() * (0 - 2 * r) + 2 * r;
                if (Math.Pow(x - r, 2) + Math.Pow(y - r, 2) <= Math.Pow(r, 2))
                {
                    k++;
                }
            }
            double s = S0 * k / n; 
            double pi = s / Math.Pow(r, 2); 
            Console.WriteLine("Результат pi = {0}", pi);
            Console.WriteLine("Точно pi = {0}", Math.PI);
        }
        static void S()
        {
            Random rnd = new Random(); 
            int n = 10000000;  
            double a = 5;   
            double b = 8.5; 
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - b) + b;
                double y = rnd.NextDouble() * (0 - a) + a;
                if ((x / 3 <= y) && (y <= (x * (10 - x)) / 5))
                {
                    k++;
                }
            }
            double S = a * b * k / n;
            Console.WriteLine("S фигуры = {0}", S);
        }
        static void W1(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (15 + 5) - 5;
                double y = rnd.NextDouble() * (1 + 1) - 1;
                if (y <= Math.Sin(x))
                {
                    k++;
                }
            }
            double S = (k / n) * 20 * 2;
            Console.WriteLine("1. y = sin (x), y = 0 \nS = {0}", S);
        }
        static void W2(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 + 7) - 7; 
                double y = rnd.NextDouble() * (0 - 8) + 8; 
                if (y <= ((x * (8 - x)) / 2) && y >= (x / 2))
                {
                    k++;
                }
            }
            double S = (k / n) * 7 * 8;
            Console.WriteLine("2. y = (x * (8 - x)) / 2, y = x/2\nS = {0}", S);
        }
        static void W3(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 12) + 12; 
                double y = rnd.NextDouble() * (0 - 6) + 6; 
                if (y <= 6 && y >= Math.Pow((x - 6), 2) / 6)
                {
                    k++;
                }
            }
            double S = (k / n) * 12 * 6;
            Console.WriteLine("3. y = (x-6)^2/6, y = 6\nS = {0}", S);
        }
        static void W4(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 2.5) + 2.04; 
                double y = rnd.NextDouble() * (0 - 4) + 4; 
                if (y <= ((x * (12 - x)) / 9) && y >= x / 5)
                {
                    k++;
                }
            }
            double S = (k / n) * 2.5 * 4;
            Console.WriteLine("4. y = x(12-x)/9, y = x/5\nS = {0}", S);
        }
        static void W5(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 8) + 8; 
                double y = rnd.NextDouble() * (0 - 5) + 5; 
                if (y <= ((x * (8 - x)) / 4) && y >= (8 - x) / x)
                {
                    k++;
                }
            }
            double S = (k / n) * 8 * 5;
            Console.WriteLine("5. y = (x*(8-x))/4, y = (8-x)/8\nS = {0}", S);
        }
        static void W6(int n)
        {
            Random rnd = new Random();
            double k = 0;
            for (int i = 0; i < n; i++)
            {
                double x = rnd.NextDouble() * (0 - 3) + 3; 
                double y = rnd.NextDouble(); 
                if (y <= Math.Sin(x) && y >= Math.Pow((x - 2), 2) / 2)
                {
                    k++;
                }
            }
            double S = (k / n) * 3 * 1;
            Console.WriteLine("6. y = sin (x), y = (x-2)^2/2\nS = {0}", S);
        }
        static void VSIO()
        {
            int n = 10000000;  
            VicPi(); 
            S();
            W1(n);
            W2(n);
            W3(n);
            W4(n);
            W5(n);
            W6(n);
        }
        static void Main(string[] args)
        {
            VSIO();
        }
    }
}

