public class CollectData {

   // Get the data from the user about the card
    private string raceInputFromUser() {
        Console.Write("What Race is this unit [Protoss, Terran, or Zerg]: ");
        string inputRace = Console.ReadLine() ?? "";

        return inputRace; 
    }

    private int powerInputFromUser() {
        Console.Write("How much Power does this unit have: ");
        string temp = Console.ReadLine() ?? "";
        //convert to an integer
        int inputPower = Convert.ToInt32(temp);
        
        return inputPower;
    }
    
    private int healthInputFromUser() {
        Console.Write("How much Health does this unit have: ");
        string temp = Console.ReadLine() ?? "";
        //convert to an integer
        int inputHealth = Convert.ToInt32(temp);
        
        return inputHealth;
    }

    private int mineralCostInputFromUser() {
        Console.Write("How much Mineral cost does this unit have: ");
        string temp = Console.ReadLine() ?? "";
        //convert to an integer
        int inputCostMineral = Convert.ToInt32(temp);
        
        return inputCostMineral;
    }

    private int gasCostInputFromUser() {
        Console.Write("How much Gas cost does this unit have: ");
        string temp = Console.ReadLine() ?? "";
        //convert to an integer
        int inputCostGas = Convert.ToInt32(temp);
        
        return inputCostGas;
    }

    private string cardTextInputFromUser() {
        Console.Write("What is the text of this card: ");
        string inputCardText = Console.ReadLine() ?? "";
        
        return inputCardText;
    }

    private string cardNameInputFromUser() {
        Console.Write("What is the name of this card: ");
        string inputCardName = Console.ReadLine() ?? "";

        return inputCardName;
    }

    private int shieldInputFromUser() {
        Console.Write("How much Shield does this unit have: ");
        string temp = Console.ReadLine() ?? "";
        //convert to an integer
        int inputShield = Convert.ToInt32(temp);

        return inputShield;
    }

    public Card generateCard() {
        // Determine what card display is needed from Race input
        var raceInput = raceInputFromUser();

        // Declare...
        Card card;
        // Fill in value based on Race
        if (raceInput == "Protoss") {
            card = new Protoss();
        }
        else {
            card = new Card();
        }

        // Start collecting data from top left of card to bottom right
        card.setRace(raceInput);
        card.setCardName(cardNameInputFromUser());
        card.setCostGas(gasCostInputFromUser());
        card.setCostMineral(mineralCostInputFromUser());
        card.setCardText(cardTextInputFromUser());
        card.setPower(powerInputFromUser());
        card.setHealth(healthInputFromUser());
        if (raceInput == "Protoss" || raceInput == "protoss") {
            card.setShield(shieldInputFromUser());
        }

        // Return new card filled out
        return card;
    }
}