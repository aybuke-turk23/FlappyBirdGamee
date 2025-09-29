namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
        

        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 20;    
            this.KeyPreview= true;  
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }



        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!!";
            
        }

        private void gametimerEvent(object sender, EventArgs e)
        {
            flappybird.Top += gravity;
            altengel.Left -= pipeSpeed;
            ustengel.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if (altengel.Left < -150)
            {
                altengel.Left = 800;
                score++;
            }
            if (ustengel.Left < -180)
            {
                ustengel.Left = 950;
                
            }
            if (flappybird.Bounds.IntersectsWith(ustengel.Bounds) ||
                flappybird.Bounds.IntersectsWith(altengel.Bounds) ||
                flappybird.Bounds.IntersectsWith(zemin.Bounds) ||
                flappybird.Top < -25)
            {
                endGame();
            }
            if (score >= 5)
            {
                pipeSpeed = 12;
            }
            if (score >= 10)
            {
               pipeSpeed = 15;
            }

            if(gravity < 15)
            {
                gravity += 1;
            }   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
        }


    }
}
