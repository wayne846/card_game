using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******************************
可腳本化物件，用來存放卡牌資訊，被所有種類的卡牌繼承
*******************************/

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

public class Card : ScriptableObject
{
    public int id;
    public string cardName;
    public CardType cardType;
    public CardState cardState;
    public bool isCovered; //是否被覆蓋
    public bool isHovered; //滑鼠是否懸浮在卡牌上
    public int cost;
    public string cardDescription;

    public virtual void use(){}
}


