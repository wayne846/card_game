using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    public int id;
    public string cardName;
    public CardType cardType;
    public CardState cardState;
    public bool isCovered;
    public int cost;
    public string cardDescription;

    public enum CardType{
        Attack,
        Defense,
        Action
    }

    public enum CardState{
        Hand,
        Table,
        Deck,
        Discard
    }

    public virtual void use(){}
}


