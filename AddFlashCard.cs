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
    public partial class AddFlashCard : Form
    {
        List<FlashCardsModel> FlashCards;
        string cardfront = string.Empty;
        string cardback = string.Empty;
        string cardsubject = string.Empty;

        public AddFlashCard()
        {
            InitializeComponent();
        }

        public AddFlashCard(List<FlashCardsModel> fc)
        {
            InitializeComponent();
            FlashCards = fc;
        }

        private void AddFlashCard_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }



        private void btnConfirmCard_Click(object sender, EventArgs e)
        {
            if (!this.Validation())
                return;

            //adds the card to the data list
            FlashCards.Add(new FlashCardsModel(this.txtEnterFront.Text.Trim(), this.txtEnterBack.Text.Trim(), this.txtEnterSubject.Text.Trim(), "None"));

            //After the user adds a card, the form then closes and they return to the view cards screen.
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadViewFlashCards));
            t.Start();
        }
     
        //Is the AddToList() method necessary?
        public void AddToList()
        {
            //LINQ - Get Front of the Field Data from ArrayList
            var allFlashCardsList = (from d in FlashCards select d.Front).ToList();
           
        }
        public void ThreadViewFlashCards()
        {
            Application.Run(new ViewFlashCards(FlashCards));
        }

        private bool Validation()
        {
            bool passed = true;

            if (this.txtEnterFront.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Front of Card cannot be Empty!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txtEnterFront;
                return false;
            }
            else if (this.txtEnterBack.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Back of Card cannot be Empty!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txtEnterBack;
                return false;
            }
            else if (this.txtEnterSubject.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Subject of Card cannot be Empty!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txtEnterSubject;
                return false;
            }

            cardfront = this.txtEnterFront.Text.Trim();
            cardback = this.txtEnterBack.Text.Trim();
            cardsubject = this.txtEnterSubject.Text.Trim();

            return passed;
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
            this.UpdateFlashCards();
            Application.Run(new Welcome(FlashCards));
        }

        private void UpdateFlashCards()
        {
        }
    }
}
