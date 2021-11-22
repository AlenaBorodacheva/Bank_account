using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Lesson_6_.RPG.Transports
{
    class Vehicle
    {
        private int _speed;

        public int Speed
        {
            get { return _speed; }
            private set { _speed = value; }
        }

        protected virtual int _maxSpeed {get; set;}

        protected Vehicle()
        {
            _speed = 0;
        }
            
        public void Accelerate(int mph) 
        {
            if (_speed + mph <= _maxSpeed)
                _speed += mph;
            else
                _speed = _maxSpeed;
        }

        public void Decelerate(int mph) 
        { 
            _speed -= mph;
        }

        public virtual void Sound()
        {
                Console.WriteLine("Ron-don-don");
        }

        public void Move(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Turning left");
            else
                Console.WriteLine("Tirning right");
        }
    }
}
