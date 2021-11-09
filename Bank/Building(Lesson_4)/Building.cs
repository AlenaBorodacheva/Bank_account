using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_Lesson_4_
{
    class Building : House
    {      
        private static int lastNumber = 0;
        private int number;
        private double high;
        private int numberOfLevels;
        private int numberOfAprtments;
        private int numberOfEntrances;

        internal Building()
        {
            CreateNewNumber();
        }

        private void CreateNewNumber()
        {
            lastNumber++;
            number = lastNumber;
        }

        public void SetHigh(double high)
        {
            this.high = high;
        }

        public void SetNumberOfLevels(int numberOfLevels)
        {
            this.numberOfLevels = numberOfLevels;
        }

        public void SetNumberOfAprtments(int numberOfAprtments)
        {
            this.numberOfAprtments = numberOfAprtments;
        }

        public void SetNumberOfEntrances(int numberOfEntrances)
        {
            this.numberOfEntrances = numberOfEntrances;
        }

        public double GetNumber()
        {
            return number;
        }

        public double GetHigh()
        {
            return high;
        }

        public int GetNumberOfLevels()
        {
            return numberOfLevels;
        }

        public int GetNumberOfAprtments()
        {
            return numberOfAprtments;
        }

        public int GetNumberOfEntrances()
        {
            return numberOfEntrances;
        }

        public double GetHighLevel()
        {
            return high / numberOfLevels;
        }

        public int GetNumberOfApartmentOnEntrance()
        {
            return numberOfAprtments / numberOfEntrances;
        }

        public int GetNumberOfApartmentOnLevel()
        {
            return numberOfAprtments / numberOfEntrances / numberOfLevels;
        }

    }

    public abstract class House
    { 
    
    }
}
