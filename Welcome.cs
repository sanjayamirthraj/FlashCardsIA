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
    public partial class Welcome : Form
    {
        List<FlashCardsModel> FlashCards = FlashCardsModel.GetFlashCards();
        List<FlashCardsModel> FlashCardsSpecificSubject = new List<FlashCardsModel>();

        public Welcome()
        {
            InitializeComponent();
            this.PopulateSubjects();
            this.resetFlashCardList();
        }

        public Welcome(List<FlashCardsModel> fc)
        {
            InitializeComponent();
            FlashCards = fc;
            this.PopulateSubjects();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //Center Form to Screen
            this.CenterToScreen();
            //set the minimization controls
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void PopulateSubjects()
        {
           var flashcards = (from d in FlashCards select d.Subject).ToList();
            var flashcardSubjectListNoDuplicates = flashcards.Distinct().ToList();
            this.lstSubjects.DataSource = flashcardSubjectListNoDuplicates;
            lstSubjects.SelectedItem = null;
            

        }

        private void btnEditAndStudy_Click(object sender, EventArgs e)
        {
            //closing the current form 
            this.Close();
            //Creating a new thread that runs the second application
            Thread t = new Thread(new ThreadStart(ThreadViewFlashCards));
            t.Start();
        }

        private void ThreadViewFlashCards()
        {
            Application.Run(new ViewFlashCards(FlashCards));
        }

        private void btnStudy_Click(object sender, EventArgs e)
        {












            //Figure out how to work this
            String subjectToFilter = lstSubjects.SelectedItem.ToString();
            for(int i = 0; i < FlashCards.Count - 1; i++)
            {
                if (FlashCards.ElementAt(i).Subject.Contains(subjectToFilter))
                {
                    FlashCardsSpecificSubject.Add(FlashCards.ElementAt(i));
                }
            }
            
            //Creating a new thread that runs the second application
            //need to make this work
            Thread t = new Thread(new ThreadStart(ThreadStudyFlashCardsSubject));
            t.Start();
            //closing the current form 
            this.Close();
       





















         }

        public void ThreadStudyFlashCardsSubject()
        {

            Application.Run(new StudyingScreen(FlashCardsSpecificSubject));
        }

        public void ThreadStudyFlashCards()
        {
            
            Application.Run(new StudyingScreen(FlashCards));
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadAddCards));
            t.Start();
        }
        public void ThreadAddCards()
        {
            this.UpdateFlashCards();
            Application.Run(new AddFlashCard(FlashCards));
        }

        private void resetFlashCardList()
        {
            //this method will reset the flashcards after the user selects a specific subject. This resets that list to the original list
            List<FlashCardsModel> FlashCards = FlashCardsModel.GetFlashCards();

        }
        private void UpdateFlashCards()
        {
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            lstSubjects.SelectedItem = null;
        }
    }
}
