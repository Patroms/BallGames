using Ball.Common;
namespace FruitNinjaWinFormsApp

{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private static Random random = new Random();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private List<FruitBall> fruits = new List<FruitBall>();
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(4, 10); i++)
            {
                var bombNumber = random.Next(5);
                if (bombNumber == 4)
                {
                    var ball = new BombBall(this); fruits.Add(ball);
                    ball.Start();
                }
                if (bombNumber == 3)
                {
                    var ball = new Banana(this); fruits.Add(ball);
                    ball.Start();
                }
                if (bombNumber != 3 || bombNumber != 4)
                {
                    var ball = new FruitBall(this); fruits.Add(ball);
                    ball.Start();
                }
            }
            timer.Interval = random.Next(2000, 5000);
        }
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.IsMovable() && fruit.Contains(e.X, e.Y))
                {
                    fruit.StandartSpeed();
                    fruit.Stop();
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
                    if (fruit is BombBall)
                    {
                        EndGame();
                        return;
                    }
                    if (fruit is Banana)
                    {
                        fruit.SlowSpeed();
                        return;
                    }
                }
                fruit.Clear();
            }
        }
        private void EndGame()
        {
            timer.Stop();
            foreach (var fruit in fruits)
            {
                fruit.Stop();
            }
            MessageBox.Show("Игра окончена!");
        }
    }
}
