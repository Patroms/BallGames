using System.ComponentModel.DataAnnotations;

namespace SalutWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var random = new Random();
            var count = random.Next(1, 10);
            for (int i = 0; i < count; i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ball = new StartSalutBall(this);
            ball.TopReached += Ball_TopReached;
            ball.Start();
        }
        private void Ball_TopReached(object sender, Ball.Common.TopReachedEventArgs e)
        {
            var random = new Random();
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var ball = new SalutBall(this, e.X, e.Y);
                ball.Start();
            }
        }

    }
    
}
