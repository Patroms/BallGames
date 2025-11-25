using Ball.Common;

namespace BillyardBallsWinFormsApp
{

    public partial class BillyardForm : Form
    {

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        List<BillyardBall> balls = new List<BillyardBall>();
        int ballCount = 20;
        public BillyardForm()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowVerticalCenterLine();
            var leftOfCenterBlueCount = 0;
            var rightOfCenterBlueCount = 0;
            var leftOfCenterRedCount = 0;
            var rightOfCenterRedCount = 0;
            foreach (var ball in balls)
            {
                if (ball.LeftOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        leftOfCenterRedCount++;
                    }
                    else
                    {
                        leftOfCenterBlueCount++;
                    }
                }
                else
                if (ball.RightOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        rightOfCenterRedCount++;
                    }
                    else
                    {
                        rightOfCenterBlueCount++;
                    }
                }
            }
            if (leftOfCenterRedCount == leftOfCenterBlueCount && rightOfCenterBlueCount == rightOfCenterRedCount && leftOfCenterRedCount + leftOfCenterBlueCount + rightOfCenterBlueCount + rightOfCenterRedCount == ballCount)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }
        }

        protected static Random random = new Random();
        private void BilliardForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < ballCount / 2; i++)
            {
                int time = random.Next(5, 200);
                var ball = new BillyardBall(this, Brushes.Blue, time);

                ball.Start();
                balls.Add(ball);
                ball.OnHited += Ball_OnHited;
                ball.Start();

            }
            for (int i = 0; i < ballCount / 2; i++)
            {
                int time = random.Next(5, 200);
                var ball = new BillyardBall(this, Brushes.Red, time);

                ball.Start();
                balls.Add(ball);
                ball.OnHited += Ball_OnHited2;
                ball.Start();
            }
        }

        private void ShowVerticalCenterLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }


        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString(); break;
                case Side.Right: rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString(); break;
                case Side.Top: topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString(); break;
                case Side.Down: downLabel.Text = (Convert.ToInt32(downLabel.Text) + 1).ToString(); break;
            }
        }
        private void Ball_OnHited2(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left: leftLabel2.Text = (Convert.ToInt32(leftLabel2.Text) + 1).ToString(); break;
                case Side.Right: rightLabel2.Text = (Convert.ToInt32(rightLabel2.Text) + 1).ToString(); break;
                case Side.Top: topLabel2.Text = (Convert.ToInt32(topLabel2.Text) + 1).ToString(); break;
                case Side.Down: downLabel2.Text = (Convert.ToInt32(downLabel2.Text) + 1).ToString(); break;
            }
        }

    }
}