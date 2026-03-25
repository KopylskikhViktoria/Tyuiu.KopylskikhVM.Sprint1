using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KopylskikhVM.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double ctg = 1 / Math.Tan(x);
            double z = Math.Pow(1 - Math.Tan(x), ctg) + Math.Cos(x - y);
            return Math.Round(z, 3);
        }
    }
}
