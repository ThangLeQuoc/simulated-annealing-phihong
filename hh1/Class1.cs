using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Algorithms
    {
        private Random random = new Random();

        //Problem
        public double x;
        public double y;
        public double x0;
        public double y0;

        //Optimal
        public double Optimal; // z
        public double Optimal_x;
        public double Optimal_y;

        //parameter
        public readonly double alpha = 0.85;

        // k constant
        public readonly double k = 1;

        // initial temperature
        public double temp = 100;
        // finish temperature
        public double finalTemp = 0.000001;
        

        public double maxcount = 100;

        public double count = 0;

        private void Initial_Solution()
        {
            // TODO @thangle: debug to check if this assignment is correct
            
            /*
            x = imRand.Next(-3, 3) + imRand.NextDouble();
            y = imRand.Next(-2, 2) + imRand.NextDouble();
            */


        }

        private double f(double x, double y)
        {
            // @thangle: function is correct
            return (4 - 2.1 * Math.Pow(x, 2) + Math.Pow(x, 4) / 3) * Math.Pow(x, 2) + x * y + (-4 + 4 * Math.Pow(y, 2)) * Math.Pow(y, 2);
        }

        public static double GetRandomNumber(double min, double max) {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }


        private void Tweak()
        {
            x0 = x;
            y0 = y;
            while (x0 == x)
            {
                //x0 = imRand.Next(-3, 3) + imRand.NextDouble();
                x0 = x + (random.NextDouble() - 0.5);
            }
            while (y0 == y)
            {
                //y0 = imRand.Next(-2, 2) + imRand.NextDouble();
                y0 = y + (random.NextDouble() - 0.5);
            }
        }


        public void Run_Simulated_Annealing_Method()
        {
            // buoc mot: lay ngau nhien x y
            // Initial_Solution();

            x = GetRandomNumber(-3, 3);
            y = GetRandomNumber(-2, 2);

            // tinh duoc z voi gia tri x,y ban dau
            Optimal = f(x, y);

            // gan hai gia tri x, y ban dau la optimal
            Optimal_x = x;
            Optimal_y = y;

            // chay vong lap khi nhiet do con tren muc nhiet cuoi cung
            while (temp > finalTemp)
            {
                for (int i = 1; i <= maxcount; i++)
                {
                    Tweak(); // tweak generate random x0, y0
                    double delta = f(x0, y0) - f(x, y);
                    if (delta < 0)
                    {
                        x = x0;
                        y = y0;
                    }
                    else if (random.NextDouble() < Math.Exp(-delta / temp / k))
                    {
                        x = x0;
                        y = y0;
                    }

                    // find the minimum value
                    if (f(x, y) < f(Optimal_x, Optimal_y))
                    {
                        Optimal_x = x;
                        Optimal_y = y;
                        Optimal = f(x, y);
                    }
                }
                temp = temp * alpha;
            }
            Console.WriteLine("Optimal X: " + Optimal_x);
            Console.WriteLine("Optimal Y: " + Optimal_y);
            Console.WriteLine("Optimal z = f(x,y): " + Optimal);
        }
    }
}