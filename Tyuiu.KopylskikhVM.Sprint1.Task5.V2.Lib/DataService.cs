using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KopylskikhVM.Sprint1.Task5.V2.Lib
{
    public class DataService : ISprint1Task5V2
    {
        public int FahrenheitToСelsius(double temp)
        {
            double celsius = (5.0 / 9.0) * (temp - 32);
            return Convert.ToInt32(celsius);
        }
    }
}
