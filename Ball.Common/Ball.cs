using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ball.Common
{
    public class Ball
    {
        public Form form;
        protected float vx = 10;
        protected float vy = 10;
        protected float centerX = 10;
        protected float centerY = 10;
        protected Brush brush = Brushes.Blue;
        protected int time = 20;

        private System.Windows.Forms.Timer timer;

        protected int radius = 25;
        protected static Random random = new Random();

        public Ball (Form form)
        {
            this.form = form;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public Ball (Form form, Brush brush)
        {
            this.form = form;
            this.brush = brush;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public Ball(Form form, Brush brush, int time)
        {
            this.form = form;
            this.brush = brush;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = time;
            timer.Tick += Timer_Tick;
        }

        public Brush GetBrush()
        {
            return brush;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public bool IsMovable()
        {
            return timer.Enabled;
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public void Show(Brush brush)
        {
            Draw(brush);
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy; 
        }
        public void Clear()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush); 
        }
        public void Move()
        {
            Clear();
            Go();
            Show(brush);
        }

        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        public bool OnForm()
        {
            return centerX>=LeftSide() && centerX <= RightSide() && centerY >=TopSide() && centerY <= DownSide();
        }
        public bool Contains(int pointX, int pointY)
        {
            var radius = this.radius/2;
            var centerX = this.centerX+ radius;
            var centerY = this.centerY+ radius;
            return (centerX - pointX) * (centerX - pointX) + (centerY - pointY) * (centerY - pointY) <= radius * radius;

        }
        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectange = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectange);
        }

        public bool Exists(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;

            return dx*dx + dy*dy <= radius*radius;
        }
        public bool Intersect(Ball other)
        {
            var dx = centerX - other.centerX;
            var dy = centerY - other.centerY;
            return dx * dx + dy * dy <= Math.Pow(radius + other.radius, 2);
        }
        public void SlowSpeed()
        {
            time = 1;
        }
        public void StandartSpeed()
        {
            time = 20;
        }
    }

}
