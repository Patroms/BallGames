using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ball.Common;

namespace FruitNinjaWinFormsApp
{
    public class FruitBall : RandomMoveBall
    {
        private float g = 0.2f;
        private int speed = 20;
        public FruitBall(Form form) : base(form)
        {
            brush = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            radius = 30;
            centerY = form.ClientSize.Height + radius;
            vy = (float)random.NextDouble() * -6 - 7;
            time = speed;
        }
        protected override void Go()
        {
            base.Go();

            vy += g;

            if (centerY > DownSide() + 2*radius)
            {
                Stop();
            }
        }

    }
}
