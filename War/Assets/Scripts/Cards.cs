using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour
{

    public enum Suit
    {
        diamonds,
        hearts,
        clubs,
        spades
    }

    public Card twoOfHearts = new Card(Suit.hearts, 2, false, null, null);

    void Start()
    {
        print(twoOfHearts._suit);
    }

    public class Card
    {
        //fields
        public Suit _suit { get; set; }
        public int _number { get; set; }
        public bool _isFaceUp { get; set; }
        public GameObject _faceup { get; set; }
        public GameObject _facedown { get; set; }
        //constructor
        public Card(Suit suit, int number, bool isFaceUp, GameObject faceup, GameObject facedown)
        {
            _suit = suit;
            _number = number;
            _isFaceUp = isFaceUp;
            _faceup = faceup;
            _facedown = facedown;
        }
    }
}
