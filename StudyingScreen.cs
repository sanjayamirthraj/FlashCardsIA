using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanjayComSciIA
{
    public partial class StudyingScreen : Form
    {
        public StudyingScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHard_Click(object sender, EventArgs e)
        {

        }

        private void btnFlip_Click(object sender, EventArgs e)
        {

        }

        private void btnMedium_Click(object sender, EventArgs e)
        {

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {

        }

        private void StudyingScreen_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closing the current form 
            this.Close();
            //Creating a new thread that runs the second application
            Thread t = new Thread(new ThreadStart(ThreadWelcome));
            t.Start();
        }

        private void ThreadWelcome()
        {
            Application.Run(new Welcome());
        }
    }
}
