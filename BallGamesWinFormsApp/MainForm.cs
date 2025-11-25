using Ball.Common;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball.Common.Ball> balls;
        public MainForm()
        {
            InitializeComponent();
        }
        private void stop_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            foreach (var ball in balls)
            {
                if (ball.OnForm())
                {
                    countBalls++;
                }
                ball.Stop();
            }
            MessageBox.Show(countBalls.ToString());
            startButton.Enabled = false;
            clearButton.Enabled = true;
        }
        private void start_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            balls = new List<Ball.Common.Ball>();
            for (int i = 0; i < 5; i++)
            {
                var moveBall = new RandomMoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();

                var ball = new RandomSizeAndPointBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
            clearButton.Enabled = false;
            stopButton.Enabled = false;
            startButton.Enabled= true;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }
    }
}
