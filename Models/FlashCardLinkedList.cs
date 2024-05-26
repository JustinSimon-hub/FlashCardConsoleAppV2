using FlashcardApp.Models; // Correctly reference the namespace

namespace FlashcardApp.Collections
{
    public class FlashcardLinkedList
    {
        public Flashcard Head { get; set; }

        public void Add(Flashcard flashcard)
        {
            if (Head == null)
            {
                Head = flashcard;
            }
            else
            {
                Flashcard current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = flashcard;
            }
        }

        public void DisplayAll()
        {
            Flashcard current = Head;
            while (current != null)
            {
                Console.WriteLine($"Q: {current.Question}\nA: {current.Answer}\n");
                current = current.Next;
            }
        }
    }
}
