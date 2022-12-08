namespace Program {
    public class Program {
        static void Main(string[] args) {
            // Declare variables
            Card card = new Card();
            CollectData data = new CollectData();

            // Generate a new card
            Card filledCard = data.generateCard();

            // Display the filled out card
            filledCard.displayCard();
        }
    }
}