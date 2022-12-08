public class Card {

    // Declare variables for the default card
    private int health = 1;
    private int power = 0;
    private int costGas = 0;
    private int costMineral = 0;
    private int shield = 0;
    private string cardName = "defaultName";
    private string cardText = "defaultText";
    private string race = "defaultRace";

    // Getter and Setter methods
    public string getRace() {
        return race;
    }

    public void setRace(string newRace) {
        this.race = newRace;
    }

    public string getCardText() {
        return cardText;
    }

    public void setCardText(string newCardText) {
        this.cardText = newCardText;
    }

    public string getCardName() {
        return cardName;
    }

    public void setCardName(string newCardName) {
        this.cardName = newCardName;
    }

    public int getPower() {
        return power;
    }

    public void setPower(int newPower) {
        this.power = newPower;
    }

    public int getHealth() {
        return health;
    }

    public void setHealth(int newHealth) {
        this.health = newHealth;
    }

    public int getCostGas() {
        return costGas;
    }

    public void setCostGas(int newCostGas) {
        this.costGas = newCostGas;
    }

    public int getCostMineral() {
        return costMineral;
    }

    public void setCostMineral(int newCostMineral) {
        this.costMineral = newCostMineral;
    }

    // Only for Protoss cards
    public int getShield() {
        return shield;
    }
    
    public void setShield(int newShield) {
        this.shield = newShield;
    }

    public virtual void displayCard() {
        /****** Display the top line ******/
        // declare default bottom line length
        int topLine = 14;
        // get the character length of the race
        int nameLength = getCardName().Length;
        // reduce the bottom line by the amount of characters in the race
        topLine -= nameLength;

        // split the remaining dashes of the bottom line into two halves            
        int topLeftSideValue = topLine / 2;
        int topRightSideValue = topLine / 2;

        // add dashes into respective lists
        List<string> topLeftSideDash = new List<string>();
        for (int i = 0; i < topLeftSideValue; i++) {
            topLeftSideDash.Add("-");
        }

        List<string> topRightSideDash = new List<string>();
        for (int i = 0; i < topRightSideValue; i++) {
            topRightSideDash.Add("-");
        }

        // first half of the line
        foreach (var x in topLeftSideDash) {
            Console.Write("-");
        }
        // race name
        Console.Write(getCardName());
        // second half of the line
        foreach (var x in topRightSideDash) {
            Console.Write("-");
        }

        /*************************************/ 
        // Display the middle section of the card
        Console.WriteLine("");
        Console.WriteLine($"|" + getCostMineral() + "|        |" + getCostGas() + "|");
        Console.WriteLine("|-          -|");
        Console.WriteLine("|            |");

        /***** Display the text of the cards effect *******/
        // Start the left edge of the card
        Console.Write("|");

        // Card text loop
        bool isTextDone = false;
        while (isTextDone != true) {
            // Declare variables
            int cardWidth = 12;
            int i = 0;
            int totalLoopCounter = 0;
            char effectChar = getCardText()[totalLoopCounter];
            int cardTextLength = getCardText().Length;

            // Check if loop needs to run again
            while (totalLoopCounter < cardTextLength) {
                // If card row length is less than card width
                if (i < cardWidth) {
                    // Write character to screen
                    Console.Write(effectChar);
                    // Advance cardWidth counter
                    i++;
                    // Advance the index of the cardText
                    totalLoopCounter++;
                    // IndexOutOfRange check
                    if (totalLoopCounter != getCardText().Length) {
                        effectChar = getCardText()[totalLoopCounter];
                    }
                }
                else if (i == cardWidth){
                    // Reset the looping variable
                    i = 0;
                    // Close the right edge of the card
                    Console.WriteLine("|");
                    // And start the next line with the left edge of the card
                    Console.Write("|");
                }
            }
            // End the card text loop
            isTextDone = true;

            // Get the remaining empty space between the text and the right of the card
            while (i < 12) {
                Console.Write(" ");
                i++;
            }

        // Close the right edge of the the card
        Console.WriteLine("|");
        }

        //Console.WriteLine("");
        Console.WriteLine("|            |");
        Console.WriteLine("|            |");
        Console.WriteLine("|_          _|");
        Console.WriteLine("|" + getPower() + "|        |" + getHealth() + "|");

        /*************************************/
        /****** Display the bottom line ******/
        // declare default bottom line length
        int bottomLine = 14;
        // get the character length of the race
        int raceLength = getRace().Length;
        // reduce the bottom line by the amount of characters in the race
        bottomLine -= raceLength;

        // split the remaining dashes of the bottom line into two halves            
        int bottomLeftSideValue = bottomLine / 2;
        int bottomRightSideValue = bottomLine / 2;

        // add dashes into respective lists
        List<string> bottomLeftSideDash = new List<string>();
        for (int i = 0; i < bottomLeftSideValue; i++) {
            bottomLeftSideDash.Add("-");
        }

        List<string> bottomRightSideDash = new List<string>();
        for (int i = 0; i < bottomRightSideValue; i++) {
            bottomRightSideDash.Add("-");
        }

        // first half of the line
        foreach (var x in bottomLeftSideDash) {
            Console.Write("-");
        }
        // race name
        Console.Write(getRace());
        // second half of the line
        foreach (var x in bottomRightSideDash) {
            Console.Write("-");
        }
        /*************************************/
    }
}
