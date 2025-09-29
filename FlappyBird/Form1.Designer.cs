
namespace FlappyBird
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
            altengel = new PictureBox();
            zemin = new PictureBox();
            ustengel = new PictureBox();
            flappybird = new PictureBox();
            bulut2 = new PictureBox();
            bulut3 = new PictureBox();
            bulut1 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            gameTimer.Tick += gametimerEvent;
            scoreText = new Label();
            ((System.ComponentModel.ISupportInitialize)altengel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ustengel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappybird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulut2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulut3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulut1).BeginInit();
            SuspendLayout();
            // 
            // altengel
            // 
            altengel.Image = Properties.Resources.pipe;
            altengel.Location = new Point(359, 245);
            altengel.Name = "altengel";
            altengel.Size = new Size(70, 153);
            altengel.SizeMode = PictureBoxSizeMode.StretchImage;
            altengel.TabIndex = 0;
            altengel.TabStop = false;
            // 
            // zemin
            // 
            zemin.Image = Properties.Resources.ground;
            zemin.Location = new Point(-7, 394);
            zemin.Name = "zemin";
            zemin.Size = new Size(818, 62);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 1;
            zemin.TabStop = false;
            // 
            // ustengel
            // 
            ustengel.Image = Properties.Resources.pipedown;
            ustengel.Location = new Point(617, -12);
            ustengel.Name = "ustengel";
            ustengel.Size = new Size(66, 183);
            ustengel.SizeMode = PictureBoxSizeMode.StretchImage;
            ustengel.TabIndex = 2;
            ustengel.TabStop = false;
            // 
            // flappybird
            // 
            flappybird.Image = Properties.Resources.bird;
            flappybird.Location = new Point(12, 109);
            flappybird.Name = "flappybird";
            flappybird.Size = new Size(70, 51);
            flappybird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappybird.TabIndex = 3;
            flappybird.TabStop = false;
            // 
            // bulut2
            // 
            bulut2.Image = Properties.Resources.pngwing_com;
            bulut2.Location = new Point(252, 109);
            bulut2.Name = "bulut2";
            bulut2.Size = new Size(125, 62);
            bulut2.SizeMode = PictureBoxSizeMode.StretchImage;
            bulut2.TabIndex = 4;
            bulut2.TabStop = false;
            // 
            // bulut3
            // 
            bulut3.Image = Properties.Resources.pngwing_com;
            bulut3.Location = new Point(486, 40);
            bulut3.Name = "bulut3";
            bulut3.Size = new Size(125, 62);
            bulut3.SizeMode = PictureBoxSizeMode.StretchImage;
            bulut3.TabIndex = 5;
            bulut3.TabStop = false;
            // 
            // bulut1
            // 
            bulut1.Image = Properties.Resources.pngwing_com;
            bulut1.Location = new Point(31, 12);
            bulut1.Name = "bulut1";
            bulut1.Size = new Size(125, 62);
            bulut1.SizeMode = PictureBoxSizeMode.StretchImage;
            bulut1.TabIndex = 6;
            bulut1.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.AntiqueWhite;
            scoreText.Location = new Point(12, 421);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(43, 20);
            scoreText.TabIndex = 7;
            scoreText.Text = "skor: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreText);
            Controls.Add(flappybird);
            Controls.Add(ustengel);
            Controls.Add(zemin);
            Controls.Add(bulut2);
            Controls.Add(bulut1);
            Controls.Add(bulut3);
            Controls.Add(altengel);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)altengel).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)ustengel).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappybird).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulut2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulut3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulut1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox altengel;
        private PictureBox zemin;
        private PictureBox ustengel;
        private PictureBox flappybird;
        private PictureBox bulut2;
        private PictureBox bulut3;
        private PictureBox bulut1;
        private System.Windows.Forms.Timer gameTimer;
        private Label scoreText;
    }
}
