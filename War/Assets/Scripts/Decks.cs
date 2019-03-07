using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decks : MonoBehaviour
{
    private Cards cards;

    void Start()
    {
        cards = GetComponent<Cards>();
        Deck preShuffleDeck = new Deck(new List<Cards.Card>());

        preShuffleDeck._deck.Add(cards.twoOfHearts);

        

    }
    public class Deck
    {

        //fields
        public List<Cards.Card> _deck { get; set; }

        //constructor
        public Deck(List<Cards.Card> deck)
        {
            _deck = deck;
        }
    }
}
