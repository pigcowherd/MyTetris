using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTetris
{
    class BrickFactory
    {
        public void CreateBrick(Form1 f)
        {
            Random random = new Random();
            int type = random.Next(4);
            int state = random.Next(4);

            f.CurrentType = type;
            f.CurrentState = state;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    f.CurrentBrick[y, x] = f.brick[type, state, y, x];
                }
            }


            f.CurrentX = 0;
            f.CurrentY = 0;

         }
    }
}
