namespace FlappyBirdGamee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameTimer = new System.Windows.Forms.Timer(components);
            zemin = new PictureBox();
            altEngel = new PictureBox();
            ustEngel = new PictureBox();
            flappybird = new PictureBox();
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)altEngel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ustEngel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappybird).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // zemin
            // 
            zemin.Image = Properties.Resources.ground;
            zemin.Location = new Point(0, 396);
            zemin.Name = "zemin";
            zemin.Size = new Size(819, 62);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 0;
            zemin.TabStop = false;
            // 
            // altEngel
            // 
            altEngel.Image = Properties.Resources.pipe;
            altEngel.Location = new Point(373, 263);
            altEngel.Name = "altEngel";
            altEngel.Size = new Size(62, 143);
            altEngel.SizeMode = PictureBoxSizeMode.StretchImage;
            altEngel.TabIndex = 1;
            altEngel.TabStop = false;
            altEngel.Click += altEngel_Click;
            // 
            // ustEngel
            // 
            ustEngel.Image = Properties.Resources.pipedown;
            ustEngel.Location = new Point(621, 1);
            ustEngel.Name = "ustEngel";
            ustEngel.Size = new Size(60, 155);
            ustEngel.SizeMode = PictureBoxSizeMode.StretchImage;
            ustEngel.TabIndex = 2;
            ustEngel.TabStop = false;
            ustEngel.Click += pictureBox3_Click;
            // 
            // flappybird
            // 
            flappybird.Image = Properties.Resources.bird;
            flappybird.Location = new Point(65, 138);
            flappybird.Name = "flappybird";
            flappybird.Size = new Size(72, 62);
            flappybird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappybird.TabIndex = 3;
            flappybird.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.BackColor = Color.PaleGoldenrod;
            scoreText.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(0, 409);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(131, 49);
            scoreText.TabIndex = 4;
            scoreText.Text = "skor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreText);
            Controls.Add(flappybird);
            Controls.Add(ustEngel);
            Controls.Add(zemin);
            Controls.Add(altEngel);
            Name = "Form1";
            Text = "FlappyBirdGamee";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)altEngel).EndInit();
            ((System.ComponentModel.ISupportInitialize)ustEngel).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappybird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private PictureBox zemin;
        private PictureBox altEngel;
        private PictureBox ustEngel;
        private PictureBox flappybird;
        private Label scoreText;
    }
}
