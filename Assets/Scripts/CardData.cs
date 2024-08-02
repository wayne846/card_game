using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CardData : MonoBehaviour
{
    public Card cardData;

    public int id;
    public string cardName;
    public CardType cardType;
    public CardState cardState;
    public bool isCovered; //是否被覆蓋
    public bool isHovered; //滑鼠是否懸浮在卡牌上
    public int cost;
    public string cardDescription;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
