using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjayComSciIA.Models
{
    public class FlashCardsModel
    {
        //setting all the class variables
        public string Front { get; set; }
        public string Back { get; set; }
        public string Subject { get; set; }
        public string Difficulty { get; set; }

        public FlashCardsModel()
        {
            
        }
        //setting up the constructor
        public FlashCardsModel(string f, string b, string s, string d)
        {
            //setting up all the variables
            Front = f;
            Back = b;
            Subject = s;
            Difficulty = d;
        }

        public static List<FlashCardsModel> GetFlashCards()
        {
            return new List<FlashCardsModel>
            {
              new FlashCardsModel("Front", "Back", "Subject", "Hard"),
              new FlashCardsModel("Front1", "Back1", "Subject1", "Hard1"),
              new FlashCardsModel("Front2", "Back2", "Subject2", "Hard2"),
              
            };
        }
    }
}