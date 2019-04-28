using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Algorithms
    {
        private Random imRand = new Random();

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

        // @thangle: Hang so giam nhiet alpha
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
            x = imRand.Next(-3, 3) + imRand.NextDouble();
            y = imRand.Next(-2, 2) + imRand.NextDouble();
        }

        private double f(double x, double y)
        {
            // @thangle: function is correct
            return (4 - 2.1 * Math.Pow(x, 2) + 1 / 3 * Math.Pow(x, 4)) * Math.Pow(x, 2) + x * y + Math.Pow(y, 2) * (-4 + 4 * Math.Pow(y, 2));
        }


        private void Tweak()
        {
            x0 = x;
            y0 = y;
            while (x0 == x)
            {
                x0 = imRand.Next(-3, 3) + imRand.NextDouble();
            }
            while (y0 == y)
            {
                y0 = imRand.Next(-2, 2) + imRand.NextDouble();
            }

            // TODO @thangle: Cho tweak nay (lay random x,y) co ve co van de, vi yeu cau van phai nam trong range x [-3,3] chu
            /*
             * Solution cu
            copy_x = x + (imRand.NextDouble() - 0.5);
            copy_y = y + (imRand.NextDouble() - 0.5);
            */
        }

        // @thangle: main run
        public void Run_Simulated_Annealing_Method()
        {
            // buoc mot: lay ngau nhien x y
            Initial_Solution();

            // tinh duoc z voi gia tri x,y ban dau
            Optimal = f(x, y);

            // gan hai gia tri x, y ban dau la optimal
            Optimal_x = x;
            Optimal_y = y;

            // chay vong lap khi nhiet do con tren muc nhiet cuoi cung
            while (temp > finalTemp)
            {
                int i = 1;
                while (i <= maxcount) {
                    Tweak(); // tweak generate random x,y to assign to x0, y0
                    double delta = f(x, y) - f(x0, y0);
                    if (delta < 0) {
                        x = x0;
                        y = y0;
                    }


                }
                   
                if (f(x0, y0) < f(x, y))
                {
                    x = x0;
                    y = y0;
                }
                else
                    if (imRand.NextDouble() < Math.Exp((f(x, y) - f(x0, y0))/temp/k));
                {
                    x = x0;
                    y = y0;
                }
                if (f(x, y) < f(Optimal_x, Optimal_y))
                {
                    x = Optimal_x;
                    y = Optimal_y;
                }
                i = i + 1;
            }
            count = count + 1;
            temp = temp * alpha;
        }
    }
}