using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS18_Troll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openChildWindow()
        {
            Form1 childForm = new Form1();
            childForm.ShowDialog();
        }
        private void openPLAWindow()
        {

            Form2 childForm = new Form2();
            childForm.ShowDialog();
        }

        private void openHDWindow()
        {

            Form3 childForm = new Form3();
            childForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The davinci virus has taken over your computer, click on Support to get your flu shot");
            openPLAWindow();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://Support.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openHDWindow();
        }
    }
}
