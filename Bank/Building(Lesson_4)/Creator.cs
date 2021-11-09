using Building_Lesson_4_.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Lesson_4_
{
    abstract class Creator
    {
        protected Creator()
        {

        }

        abstract public House CreateBuild();

        abstract public House CreateBuild(double high);

        abstract public House CreateBuild(Value value);

        abstract public House CreateBuild(Value value1, Value value2);

        abstract public House CreateBuild(Value value1, Value value2, Value value3);

        abstract public House CreateBuild(double high, Value value);

        abstract public House CreateBuild(double high, Value value1, Value value2);

        abstract public House CreateBuild(double high, Value value1, Value value2, Value value3);

        abstract public void DeleteBuilding(int num);
    }
}
