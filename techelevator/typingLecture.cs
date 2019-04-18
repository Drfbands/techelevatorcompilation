using System;

public class Card
{
	public Card()
	{

        /// <summary>
        /// You must make the method before the /// comment works right 
        /// </summary>
        public string suit { get; }
        public int value { get; set; }
        public bool isFaceup { get; private set;  } // private set means that you set the value in the constructor



    // TODO add a propery to hols card value '


    // TODO create Constructor to build card 
    /// <summary>
    /// This is the suits with ascii character values for there design. 
    /// There is characters for emojis as well. 
    /// </summary>
    static Dictionary<string, char> suitSymbols = new Dictionary<string, char>()
        {
            {"Spades", '\u2660' }
        };


    //TODO make a constructor
            
    /// <summary>
    /// Holdsall values and text representation of a card. 
    /// </summary>
    static Dictionary<int, string> facevalue = new Dictionary<int, string>()
    {
        {1, "Ace" },
        {2, "Two" }
    };

    public Card(int value, string suit)
    {
        Suit = Suit;
        value = value;
    }

	}
     publiv void toggleFlip()
{
    isFaceup = !isFaceup;
}
}


//Mock Program file:

   using card;

 Card card = new Card(8, "hearts");
Console>WriteLine($"")