using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace project
{
    class Form3 : Form
    {
        private Label label1;
        private Label label2;
        private Timer timer1;
        private System.ComponentModel.IContainer components;
        private Panel panel1;
        private int y;
        private Timer timer2;
        private int speed;
        private Random time = new Random();
        private Panel[] blobs = new Panel[20];
        private Timer timer3;
        private Label label3;
        private Label label4;
        private int number_of_blobs = 0;
        private Boolean gameOver = false;

        public Form3()
        {
            InitializeComponent();
            y = panel1.Location.Y;
            label2.Text = "y: " + panel1.Location.Y;
            speed = -8;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(100, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(289, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(390, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form3_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (gameOver)
            {
                project_with_menu.Form1 mainForm = new project_with_menu.Form1();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                timer1.Start();
                timer2.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Location.Y < y - 160)
            {
                speed = 16;
            }
            if (panel1.Location.Y > y)
            {
                speed = -8;
                timer1.Stop();
            }
            panel1.Location = new System.Drawing.Point(100, panel1.Location.Y + speed);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(number_of_blobs);
            Random randPart = new Random();
            timer2.Interval = time.Next(500) + 500;
            blobs[number_of_blobs] = new Panel();
            blobs[number_of_blobs].Left = this.Width;
            if (randPart.Next(2) == 1)
            {
                blobs[number_of_blobs].Top = this.Height - 240;
            }
            else
            {
                blobs[number_of_blobs].Top = this.Height - 120;
            }
            blobs[number_of_blobs].Width = 30;
            blobs[number_of_blobs].Height = 120;
            blobs[number_of_blobs].BackColor = System.Drawing.Color.Green;
            this.Controls.Add(blobs[number_of_blobs]);
            number_of_blobs++;
            timer3.Start();
        }

        private void checkColision()
        {
            label4.Text = panel1.Left + " " + panel1.Top + " " + blobs[0].Left + " " + blobs[0].Top;
            if (panel1.Left > blobs[0].Left - panel1.Width && panel1.Left < blobs[0].Left + blobs[0].Width && panel1.Top > blobs[0].Top - panel1.Height && panel1.Top < blobs[0].Top + panel1.Height)
            {
                label3.Text = "Game Over";
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                gameOver = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < number_of_blobs; i++)
            {
                blobs[i].Left -= Comunication.speedBlob;
            }
            checkColision();
            if (blobs[0].Left < 20)
            {
                this.Controls.Remove(blobs[0]);
                for (int i = 0; i < number_of_blobs - 1; i++)
                {
                    blobs[i] = blobs[i + 1];
                }
                number_of_blobs--;
            }
        }
    }
}
