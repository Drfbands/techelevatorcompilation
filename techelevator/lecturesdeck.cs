using System;


public class deck
{
    
        private List<Card> Cards { get; set; } = new List<card>();// This instantiates right after the get and set. So we can start adding to it. 

       // Todo make a constructor. Constructors are always public. There is no return type in there access signature

    public deck()
    {
        foreach (string Suit in Cards.suitSymbols.Keys) // loops only the keys and not the values. 
    }
    // TODO Deal method to return a card



    // ToDo Shuffle 

	
}

