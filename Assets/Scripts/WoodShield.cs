using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card/WoodShield")]
public class WoodShield : Card
{
    public WoodShield(){
        id = 200;
        cardName = "Wood Shield";
        cardType = CardType.Defense;
        cardState = CardState.Table;
        isCovered = false;
        cost = 1;
        cardDescription = "Block 2 damage";
    }

    public override void use(){
        Debug.Log("Use Wood Shield");
    }
}
