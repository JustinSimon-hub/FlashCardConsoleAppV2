namespace FlashcardApp.Models
{
    public class Flashcard
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Flashcard Next { get; set; }
    }
}


