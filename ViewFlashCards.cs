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
    public partial class ViewFlashCards : Form
    {
        //takes a list of flashcards from the models file
        List<FlashCardsModel> FlashCards;
        //creating a variable that notes the index of a card to be edited. Can pass this along to make changes. 
        int indexOfEditCard;

        public ViewFlashCards()
        {
            InitializeComponent();
        }

        public ViewFlashCards(List<FlashCardsModel> fc)
        {
            InitializeComponent();
            FlashCards = fc;
        }


        private void ViewFlashCards_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();

            //populating the flashcards
            //FlashCards = FlashCardsModel.GetFlashCards();

            this.PopulateFlashCards();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void PopulateFlashCards()
        {
            var flashcards = (from d in FlashCards select d.Front).ToList();

            this.lstFlashCards.DataSource = flashcards;
        }
        private void btnAddCard_Click(object sender, EventArgs e)
        {
            //close the form 
            this.Close();
            //threading to the add card form
            Thread t = new Thread(new ThreadStart(ThreadAddCards));
            t.Start();
        }

        public void ThreadAddCards()
        {
            this.UpdateFlashCards();
            Application.Run(new AddFlashCard(FlashCards));
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

        private void btnEditCard_Click(object sender, EventArgs e)
        {
           
            indexOfEditCard = lstFlashCards.SelectedIndex;
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadEditFlashCards));
            t.Start();
        }
        //need to pass in the index as well to make edits
        private void ThreadEditFlashCards()
        {
            Application.Run(new EditCards(FlashCards[indexOfEditCard]));
        }



        //FIX THIS PLEASE MAKE SURE THE DATA IS STILL DELETED AFTER 
        private void AddToList()
        {
            //LINQ - Get Flashcard Field Data from ArrayList
            var results = (from d in FlashCards select d.Front).ToList();

            this.lstFlashCards.DataSource = results;
        }

        private void btnDeleteCard_Click(object sender, EventArgs e)
        {
            //select a flashcard
            var value = this.lstFlashCards.SelectedValue;

            //attempting to remove the flashcard
            FlashCards.RemoveAll(x => x.Front == value.ToString());
            FlashCards.RemoveAll(x => x.Back == value.ToString());
            FlashCards.RemoveAll(x => x.Subject == value.ToString());
            FlashCards.RemoveAll(x => x.Difficulty == value.ToString());

            this.AddToList();

            //have to make sure that the value stays deleted
        }

        private void btnConfirmSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchBar.Text;
            
           
            List<FlashCardsModel> FlashCardsSearch = new List<FlashCardsModel>();
            for(int i = 0; i < FlashCards.Count; i++)
            {
                if (FlashCards.ElementAt(i).Front.Contains(searchQuery))
                {
                    FlashCardsSearch.Add(FlashCards.ElementAt(i));
               }
            }
            var flashcards = (from d in FlashCardsSearch select d.Front).ToList();
            this.lstFlashCards.DataSource = flashcards;
        }
    }
}
