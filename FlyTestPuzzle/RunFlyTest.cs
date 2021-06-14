using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTestPuzzle
{
    public class RunFlyTest
    {
        public static void RunFlyTestApp()
        {
            Airplane biplane = new Airplane();
            biplane.SetSpeed(212);
            Console.WriteLine(biplane.GetSpeed());

            Jet boeing = new Jet();
            boeing.SetSpeed(422);
            Console.WriteLine(boeing.GetSpeed());

            int x = 0;
            while (x < 4)
            {
                boeing.Accelerate();
                Console.WriteLine(boeing.GetSpeed());

                if (boeing.GetSpeed() > 5000)
                {
                    biplane.SetSpeed(424 * 2);
                } else
                {
                    boeing.Accelerate();
                }

                x++;
            }

            Console.WriteLine(biplane.Accelerate());
        }
    }
}
