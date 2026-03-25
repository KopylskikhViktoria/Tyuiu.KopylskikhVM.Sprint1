using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Formats.Asn1.AsnWriter;

namespace Tyuiu.KopylskikhVM.Sprint1.Task3.V5.Lib
{
    public class DataService : ISprint1Task3V5
    {
        public double DistanceLength(double mapScale, double distanceBetweenPoints)
        {
            return Math.Round(mapScale * distanceBetweenPoints, 3);
        }
    }
}
