using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card cardData;

    public TMP_Text cardName;
    public TMP_Text cardCost;
    public TMP_Text cardDescription;

    // Start is called before the first frame update
    void Start()
    {
        cardName.text = cardData.cardName;
        cardCost.text = cardData.cost.ToString();
        cardDescription.text = cardData.cardDescription;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
