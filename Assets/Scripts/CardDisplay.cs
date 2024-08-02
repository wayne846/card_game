using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/******************************
放在卡牌物件上，用來顯示資訊到卡牌上的Text
*******************************/

public class CardDisplay : MonoBehaviour
{
    public Card cardData;

    public TMP_Text cardName;
    public TMP_Text cardCost;
    public TMP_Text cardDescription;

    // Start is called before the first frame update
    void Start()
    {
        updataCardData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updataCardData(){
        if(cardData == null) return;
        
        cardName.text = cardData.cardName;
        cardCost.text = cardData.cost.ToString();
        cardDescription.text = cardData.cardDescription;
    }
}
