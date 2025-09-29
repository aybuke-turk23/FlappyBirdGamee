namespace FlappyBirdGamee
{
    public partial class Form1 : Form
    {


        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        bool  gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void altEngel_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "\n Oyun Bitti!!!";
            gameOver = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            altEngel.Left -= pipeSpeed;
            ustEngel.Left -= pipeSpeed;
            scoreText.Text = "Skor: " + score.ToString();

            if (altEngel.Left < -150)
            {
                altEngel.Left = 800;
                score++;
            }
            if (ustEngel.Left < -180)
            {
                ustEngel.Left = 950;
                score++;
            }

            if (flappybird.Bounds.IntersectsWith(altEngel.Bounds) ||
                flappybird.Bounds.IntersectsWith(ustEngel.Bounds) ||
                flappybird.Bounds.IntersectsWith(zemin.Bounds)

                )
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
            if (score > 10)
            {
                pipeSpeed = 20;
            }
            if (flappybird.Top < -25)
            {
                endGame();
            }
           
        }
        private void restart()
        {
            gameOver = false;
            flappybird.Location = new Point(50, 200); // Kuþu baþlangýç pozisyonuna al

            ustEngel.Left = 300; // Borularý baþlangýç pozisyonuna al
            altEngel.Left = 300;

            score = 0;
            scoreText.Text = $"Score: {score}";

            gameTimer.Start(); // Zamanlayýcýyý tekrar baþlat
        }


    }
}

