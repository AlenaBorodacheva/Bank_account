using Building_Lesson_4_.DTO;
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
            Creator creatorBuild = new BuildingCreator();

            double high = 5000;
            Value value = new Value();
            value.NumberOf = NumberOf.Levels;
            value.Num = 5;

            House house1 = creatorBuild.CreateBuild();
            House house2 = creatorBuild.CreateBuild(high);
            House house3 = creatorBuild.CreateBuild(value);
            House house4 = creatorBuild.CreateBuild(high, value);
            creatorBuild.DeleteBuilding(2);

        }
    }
}
