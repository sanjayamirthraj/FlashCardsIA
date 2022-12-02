using SanjayComSciIA.Models;
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
        List<FlashCardsModel> FlashCards = new List<FlashCardsModel>();
        //creating a variable to move along the flashcards
        int flashcardCounter = 0;
        //creating a boolean to check if the card is on the front or the back
        bool isFront = true;
        public StudyingScreen()
        {
            InitializeComponent();
        }

        private void StudyingScreen_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            FlashCards = FlashCardsModel.GetFlashCards();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            var flashcards = (from d in FlashCards select d.Front).ToList();
            //checking if there are more cards
            if (flashcardCounter > flashcards.Count()-1)
            {
                MessageBox.Show(this, "All Cards have been Studied!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //closes the screen to return back to the main screen 
                this.Close();
                //Creating a new thread that runs the second application
                Thread t = new Thread(new ThreadStart(ThreadWelcome));
                t.Start();
                flashcardCounter--;
            }
            txtCardAnswer.Text = flashcards[flashcardCounter].ToString();
            //incrementing this flashcard value
            flashcardCounter++;

            
        }


        private void btnMedium_Click(object sender, EventArgs e)
        {
            var flashcards = (from d in FlashCards select d.Front).ToList();
            //checking if there are more cards
            if (flashcardCounter > flashcards.Count() - 1)
            {
                MessageBox.Show(this, "All Cards have been Studied!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //closes the screen to return back to the main screen 
                this.Close();
                //Creating a new thread that runs the second application
                Thread t = new Thread(new ThreadStart(ThreadWelcome));
                t.Start();
                flashcardCounter--;
            }
            txtCardAnswer.Text = flashcards[flashcardCounter].ToString();
            //incrementing this flashcard value
            flashcardCounter++;


        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            var flashcards = (from d in FlashCards select d.Front).ToList();
            //checking if there are more cards
            if (flashcardCounter > flashcards.Count() - 1)
            {
                MessageBox.Show(this, "All Cards have been Studied!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //closes the screen to return back to the main screen 
                this.Close();
                //Creating a new thread that runs the second application
                Thread t = new Thread(new ThreadStart(ThreadWelcome));
                t.Start();
                flashcardCounter--;
            }
            txtCardAnswer.Text = flashcards[flashcardCounter].ToString();
            //incrementing this flashcard value
            flashcardCounter++;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            var flashcardsFront = (from d in FlashCards select d.Front).ToList();
            var flashcardsBack = (from d in FlashCards select d.Back).ToList();
            if (isFront)
            {
                txtCardAnswer.Text = flashcardsBack[flashcardCounter].ToString();
                isFront = false;
            }
            else
            {
                txtCardAnswer.Text = flashcardsFront[flashcardCounter].ToString();
                isFront = true;
            }
            flashcardCounter++;
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            var flashcards = (from d in FlashCards select d.Front).ToList();
            txtCardAnswer.Text = flashcards.First().ToString();
        }
    }
}
