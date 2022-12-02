﻿using SanjayComSciIA.Models;
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
        List<FlashCardsModel> FlashCards = new List<FlashCardsModel>();
        public ViewFlashCards()
        {
            InitializeComponent();
        }

        private void ViewFlashCards_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();

            //populating the flashcards
            FlashCards = FlashCardsModel.GetFlashCards();

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
            var flashcards = (from d in FlashCards select d.Front + "  " + d.Difficulty).ToList();

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
            Application.Run(new AddFlashCard());
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

        private void btnEditCard_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadEditFlashCards));
            t.Start();
        }
        private void ThreadEditFlashCards()
        {
            Application.Run(new EditCards());
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
            var value = this.lstFlashCards.SelectedValue;

            FlashCards.RemoveAll(x => x.Front == value.ToString());
            FlashCards.RemoveAll(x => x.Back == value.ToString());
            FlashCards.RemoveAll(x => x.Subject == value.ToString());
            FlashCards.RemoveAll(x => x.Difficulty == value.ToString());

            this.AddToList();

            //have to make sure that the value stays deleted
        }
    }
}
