using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_with_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test1.Hide();
            test2.Hide();
            test3.Hide();
        }
        private void loadForm2(string testName)
        {
            project.Comunication.testName = testName;
            project.Form2 subForm = new project.Form2();
            this.Hide();
            subForm.Show();
        }
        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm2("test1.txt");
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm2("test2.txt");
        }

        private void test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm2("test3.txt");
        }
        private void renderJoc()
        {
            this.Hide();
            project.Form3 joc = new project.Form3();
            joc.Show();
        }

        private void nivel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderJoc();
            project.Comunication.speedBlob = 10;
        }

        private void nivel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderJoc();
            project.Comunication.speedBlob = 20;
        }

        private void nivel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            renderJoc();
            project.Comunication.speedBlob = 30;
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            test1.Text = "test1 punctaj: " + project.Comunication.punctajTest1 + "/" + 5;
            test2.Text = "test2 punctaj: " + project.Comunication.punctajTest2 + "/" + 5;
            test3.Text = "test3 punctaj: " + project.Comunication.punctajTest2 + "/" + 5;
            test3.Show();
            test2.Show();
            test1.Show();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
