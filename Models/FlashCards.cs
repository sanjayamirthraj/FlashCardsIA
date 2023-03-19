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
              new FlashCardsModel("Front", "Back", "Subject", "Easy"),
              new FlashCardsModel("Front1", "Back1", "Subject1", "Medium"),
              new FlashCardsModel("Front2", "Back2", "Subject2", "Hard"),
              new FlashCardsModel("Bilogy", "Back3", "Biology", "Easy"),
              new FlashCardsModel("Biology2", "Back4", "Biology", "Medium"),
              new FlashCardsModel("Biology3", "Back5", "Biology", "Hard"),
              new FlashCardsModel("Biology4", "Back6", "Biology", "Easy"),

            };
        }


        public static void sortFlashCards(List<FlashCardsModel> flashcards)
        {
            //add the merge sort stuff here
            //add a key to the difficulties
        }


        public static void MergeSort(List<Flashcard> flashcards, int left, int right)
{
    if (left < right)
    {
        int middle = (left + right) / 2;
        MergeSort(flashcards, left, middle);
        MergeSort(flashcards, middle + 1, right);
        Merge(flashcards, left, middle, right);
    }
}

private static void Merge(List<Flashcard> flashcards, int left, int middle, int right)
{
    List<Flashcard> leftList = new List<Flashcard>();
    List<Flashcard> rightList = new List<Flashcard>();

    for (int i = left; i <= middle; i++)
    {
        leftList.Add(flashcards[i]);
    }

    for (int i = middle + 1; i <= right; i++)
    {
        rightList.Add(flashcards[i]);
    }

    int leftIndex = 0;
    int rightIndex = 0;
    int currentIndex = left;

    while (leftIndex < leftList.Count && rightIndex < rightList.Count)
    {
        if (leftList[leftIndex].Difficulty.CompareTo(rightList[rightIndex].Difficulty) < 0)
        {
            flashcards[currentIndex] = leftList[leftIndex];
            leftIndex++;
        }
        else
        {
            flashcards[currentIndex] = rightList[rightIndex];
            rightIndex++;
        }
        currentIndex++;
    }

    while (leftIndex < leftList.Count)
    {
        flashcards[currentIndex] = leftList[leftIndex];
        leftIndex++;
        currentIndex++;
    }

    while (rightIndex < rightList.Count)
    {
        flashcards[currentIndex] = rightList[rightIndex];
        rightIndex++;
        currentIndex++;
    }
}




        
    }
}