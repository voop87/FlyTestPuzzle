using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTestPuzzle
{
    public class Jet : Airplane
    {
        private static int MULTIPLIER = 2;

        public override void SetSpeed(int speed)
        {
            Speed = speed * MULTIPLIER;
        }
    }
}
