using Building_Lesson_4_.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Lesson_4_
{
    class BuildingCreator : Creator
    {
        static Hashtable data = new Hashtable();

        public BuildingCreator() : base()
        {
            
        }

        public override House CreateBuild()
        {
            Building building = new Building();
            data.Add(building.GetNumber(), building);
            return building;
        }

        public override House CreateBuild(double high)
        {
            Building building = new Building();
            data.Add(building.GetNumber(), building);
            building.SetHigh(high);
            return building;
        }

        public override House CreateBuild(Value value)
        {
            Building building = new Building();
            data.Add(building.GetNumber(), building);
            AddAttribute(building, value);
            return building;
        }

        public override House CreateBuild(Value value1, Value value2)
        {
            Building building = new Building();
            data.Add(building.GetNumber(), building);

            foreach (var value in new Value[] { value1, value2 })
            {
                AddAttribute(building, value);
            }

            return building;
        }

        public override House CreateBuild(Value value1, Value value2, Value value3)
        {
            Building building = new Building();
            data.Add(building.GetNumber(), building);

            foreach (var value in new Value[] { value1, value2, value3 })
            {
                AddAttribute(building, value);
            }

            return building;
        }

        public override House CreateBuild(double high, Value value)
        {
            var building = CreateBuild(high);
            AddAttribute(building as Building, value);
            return building;
        }

        public override House CreateBuild(double high, Value value1, Value value2)
        {
            var building = CreateBuild(high);
            foreach (var value in new Value[] { value1, value2 })
            {
                AddAttribute(building as Building, value);
            }
            return building;
        }

        public override House CreateBuild(double high, Value value1, Value value2, Value value3)
        {
            var building = CreateBuild(high);
            foreach (var value in new Value[] { value1, value2, value3 })
            {
                AddAttribute(building as Building, value);
            }
            return building;
        }

        public override void DeleteBuilding(int key)
        {
            foreach(var d in data.Keys)
            {
                if((double)d == key)
                {
                    data.Remove(d);
                    break;
                }
            }
        }


        private void AddAttribute(Building building, Value value)
        {
            if (value.NumberOf == NumberOf.Aprtments)
            {
                building.SetNumberOfAprtments(value.Num);
            }
            else if (value.NumberOf == NumberOf.Entrances)
            {
                building.SetNumberOfEntrances(value.Num);
            }
            else if (value.NumberOf == NumberOf.Levels)
            {
                building.SetNumberOfLevels(value.Num);
            }
        }        
    }
}
