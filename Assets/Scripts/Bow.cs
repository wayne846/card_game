using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************
繼承自Card，弓
*******************************/

[CreateAssetMenu(fileName = "New Card", menuName = "Card/Bow")]
public class Bow : Card
{
    public Bow(){
        id = 100;
        cardName = "Bow";
        cardType = CardType.Attack;
        cardState = CardState.Deck;
        isCovered = false;
        isHovered = false;
        cost = 1;
        cardDescription = "Deal 1 damage";
    }

    public override void use(){
        Debug.Log("Use Bow");
    }
}
