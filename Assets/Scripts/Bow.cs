using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card/Bow")]
public class Bow : Card
{
    public Bow(){
        this.cardName = "Bow";
        this.cardType = CardType.Attack;
        this.cardState = CardState.Table;
        this.isCovered = false;
        this.cost = 1;
        this.cardDescription = "Deal 1 damage";
    }
}
