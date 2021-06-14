using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTestPuzzle
{
    public class Airplane
    {
        public int Speed { get; set; }

        public virtual void SetSpeed(int speed)
        {
            Speed = speed;
        }

        public int GetSpeed()
        {
            return Speed;
        }

        public int Accelerate()
        {
            Speed = GetSpeed() * 2;
            return Speed; 
        }
    }
}
