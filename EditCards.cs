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
    //make the editing functionality change the flashcard insteda of deleting and then adding
    public partial class EditCards : Form
    {
        List<FlashCardsModel> FlashCards;
        FlashCardsModel editFlash = new FlashCardsModel();
        FlashCardsModel editFlashNew = new FlashCardsModel();
        public EditCards()
        {
            InitializeComponent();
        }

        public EditCards(FlashCardsModel fc)
        {
            InitializeComponent();
            //sets the edit textboxes to what the flashcard was
            editFlash = fc;
            txtEditFront.Text = editFlash.Front;
            txtEditBack.Text = editFlash.Back;
            txtEditSubject.Text = editFlash.Subject;

        }

        public EditCards(int v)
        {
        }

        private void EditCards_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            if (!this.Validation())
                return;
            //if this passes validation, then the card is replaced with this edited card






            //need to figure out how to find the position of the object in the list
            //int indexOfEditFlashOld = FlashCards.FindIndex(s => s.Front.Equals(editFlash.Front));











            editFlashNew = new FlashCardsModel(this.txtEditFront.Text.Trim(), this.txtEditBack.Text.Trim(), this.txtEditSubject.Text.Trim(), "None");
            FlashCards[indexOfEditFlashOld] = editFlashNew;
        }

        private bool Validation()
        {
            bool passed = true;

            if (this.txtEditFront.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Front of Card cannot be Empty!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txtEditFront;
                return false;
            }
            else if (this.txtEditBack.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Back of Card cannot be Empty!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txtEditBack;
                return false;
            }
            else if (this.txtEditSubject.Text.Trim() == string.Empty)
            {
                MessageBox.Show(this, "Subject of Card cannot be Empty!", Titles.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = this.txtEditSubject;
                return false;
            }

            //cardfront = this.txtEditFront.Text.Trim();
            //cardback = this.txtEditBack.Text.Trim();
            //cardsubject = this.txtEditSubject.Text.Trim();

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
            Application.Run(new Welcome());
        }
    }
}
