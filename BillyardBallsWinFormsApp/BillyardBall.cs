using Ball.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillyardBallsWinFormsApp
{
    
    public class BillyardBall : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        public BillyardBall(Form form) : base(form)
        {

        }
        public BillyardBall(Form form, Brush brush) : base(form)
        {
            this.brush = brush;

        }
        public BillyardBall(Form form, Brush brush, int time) : base(form)
        {
            this.brush = brush;
            radius = 10;
            centerX = random.Next(LeftSide(), RightSide());
            centerX = random.Next(TopSide(), DownSide());
        }

        public bool LeftOfCenter()
        {
            return centerX + radius < form.ClientSize.Width / 2;
        }

        public bool RightOfCenter()
        {
            return centerX - radius < form.ClientSize.Width / 2;
        }


        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
