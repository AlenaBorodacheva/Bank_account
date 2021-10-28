using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Lesson_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();

            building.SetHigh(15000);
            building.SetNumberOfAprtments(100);
            building.SetNumberOfEntrances(4);
            building.SetNumberOfLevels(5);

            double highLevel = building.GetHighLevel();
            int numberOfApartmentOnEntrance = building.GetNumberOfApartmentOnEntrance();
            int numberOfApartmentOnLevel = building.GetNumberOfApartmentOnLevel();
        }
    }
}
