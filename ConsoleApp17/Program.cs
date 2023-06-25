using System;

namespace ConsoleApp17
{
    class beizi
    {
        private double rmin;
        private double rmax;
        public double Rmin
        {
            get { return rmin; }
            set { rmin = value; }
        }
        public double Rmax
        {
            get { return rmax; }
            set { rmax = value; }
        }
        public beizi() { }
        public beizi(double rmin,double rmax)
        {
            rmax = Rmax;
            rmin = Rmin;
        }
        public double calc()
        {
            double result = rmin * rmax * 3.14;
            return result;
        }
    }
    class main
    {
        public static void Main()
        {
            beizi b = new beizi();
            b.Rmax = Convert.ToDouble(Console.ReadLine());
            b.Rmin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(b.calc());
        }
    }
}
