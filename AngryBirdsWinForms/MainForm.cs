namespace AngryBirdsWinForms
{
    public partial class MainForm : Form
    {
        Bird bird;
        Pig pig;
        int scoreLabelCount = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (bird.Intersect(pig))
            {
                scoreLabelCount++;
                scoreLabel.Text = scoreLabelCount.ToString();
                CreateNewBird();
                CreateNewPig();
            }
            if (!bird.IsMovable())
            {
                CreateNewBird();
            }

            if(bird.IsOutSide())
            {
                CreateNewBird();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateNewBird();
            CreateNewPig();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            scoreLabel.Text = "0";
            CreateNewBird();
            CreateNewPig();
        }

        private void CreateNewPig()
        {
            if (pig != null)
            {
                pig.Clear();
            }
            pig = new Pig(this);
            var brushPig = Brushes.Pink;
            pig.Show(brushPig);
        }

        void CreateNewBird()
        {
            timer.Stop();
            if(bird != null)
            {
                bird.Stop();
                bird.Clear();
            }
            bird = new Bird(this);
            var brush = Brushes.Yellow;
            bird.Show(brush);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            bird.SetVelocity(e.X, e.Y);
            timer.Start();
            bird.Start();
        }
    }
}
