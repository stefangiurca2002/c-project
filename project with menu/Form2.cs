using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form2 : Form
    {
        private Label intrebare;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private int corentAnswar;
        private Button submit;
        private StreamReader f;

        public Form2()
        {
            InitializeComponent();
            f = new StreamReader(Comunication.testName);
            read();
        }

        private void read()
        {
            intrebare.Text = f.ReadLine();
            checkBox1.Text = f.ReadLine();
            checkBox1.Checked = false;
            checkBox2.Text = f.ReadLine();
            checkBox2.Checked = false;
            checkBox3.Text = f.ReadLine();
            checkBox3.Checked = false;
            checkBox4.Text = f.ReadLine();
            checkBox4.Checked = false;
            corentAnswar = Convert.ToInt32(f.ReadLine());
            if (intrebare.Text.Length == 0)
            {
                project_with_menu.Form1 mainForm = new project_with_menu.Form1();
                this.Hide();
                mainForm.Show();
            }
        }

        private void InitializeComponent()
        {
            this.intrebare = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intrebare
            // 
            this.intrebare.AutoSize = true;
            this.intrebare.Location = new System.Drawing.Point(133, 51);
            this.intrebare.Name = "intrebare";
            this.intrebare.Size = new System.Drawing.Size(69, 20);
            this.intrebare.TabIndex = 0;
            this.intrebare.Text = "intrebare";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(123, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(123, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(123, 223);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 24);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(123, 270);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(101, 24);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(444, 236);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(164, 73);
            this.submit.TabIndex = 2;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.intrebare);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            switch (corentAnswar)
            {
                case 1:
                    if (checkBox1.Checked)
                    {
                        Comunication.setPunctaj();
                    }
                    break;
                case 2:
                    if (checkBox2.Checked)
                        Comunication.setPunctaj();
                    break;
                case 3:
                    if (checkBox3.Checked)
                        Comunication.setPunctaj();
                    break;
                default:
                    if (checkBox4.Checked)
                        Comunication.setPunctaj();
                    break;
            }
            read();
        }
    }
}
