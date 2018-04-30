using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Windows.Forms;

namespace CS18_Troll
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
            simpleSound.Play();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }
    }
}
