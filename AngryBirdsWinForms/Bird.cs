using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ball.Common;

namespace AngryBirdsWinForms
{

    public class Bird : MoveBall
    {
        private float g = 0.2f;
        private float elastic = 0.4f;
        public Bird(Form form) : base(form)
        {
            centerX = LeftSide();
            centerY = DownSide();
            brush = Brushes.Yellow;
        }
        protected override void Go()
        {
            base.Go();
            if (centerY > DownSide())
            {
                vy = -vy;
                centerY = DownSide();
                vy = vy * elastic;
                vx = vx * elastic;
            }

            if (vy < 0.1 && vx < 0.1)
            {
                Stop();
            }

            vy += g;
        }
        public void SetVelocity(int x, int y)
        {
            vx = (x - centerX) / 25;
            vy = (y - centerY) / 25;

        }

        public bool IsOutSide()
        {
            return centerX > RightSide();

        }
    }
}
