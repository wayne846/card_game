using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using static Card;

/******************************
管理卡牌相關的事情
*******************************/

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;

    public List<GameObject> deck = new List<GameObject>(); //抽牌區 deck[0]是頂端
    public List<GameObject> hand = new List<GameObject>(); //手牌
    public List<GameObject> discard = new List<GameObject>(); //棄牌區

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            AddCardToDeck(CardDataBase.allCards[0]);
            AddCardToDeck(CardDataBase.allCards[1]);
        }
        shuffle();
        Draw(10);
        Debug.Log("Deck Size: " + deck.Count);
    }

    // Update is called once per frame
    void Update()
    {
        ShowHand();
    }

    //從抽牌區頂端抽number張牌到手牌
    public int Draw(int number)
    {
        if (deck.Count > number)
        {
            for (int i = hand.Count; i < number; i++)
            {
                deck[0].GetComponent<CardDisplay>().cardData.cardState = CardState.Hand;
                hand.Add(deck[0]);
                deck.Remove(deck[0]);
            }
            return 1;
        }
        else return 0;
    }

    //顯示手牌
    public void ShowHand()
    {
        Vector3 handPositionStart = new Vector3(-5, -3, -4);
        Vector3 handPositionEnd = new Vector3(5, -3, -4);

        float x = handPositionStart.x;
        float y = handPositionStart.y;
        float z = handPositionStart.z;

        float xDelta = (handPositionEnd.x - handPositionStart.x) / hand.Count;
        float zDelta = -0.02f;

        for(int i = 0;i < hand.Count; i++)
        {
            hand[i].SetActive(true);
            if (hand[i].GetComponent<CardDisplay>().cardData.isHovered){
                hand[i].transform.position = new Vector3(x, y + 1, z);
            }else{
                hand[i].transform.position = new Vector3(x, y, z);
            }
            
            x += xDelta;
            z += zDelta;
        }

        hand[0].GetComponent<CardDisplay>().cardData.isHovered = true;
    }

    //新增一張card種類的卡片到抽牌區
    public void AddCardToDeck(Card card){
        GameObject newCard = Instantiate(cardPrefab);
        newCard.GetComponent<CardDisplay>().cardData = card;
        newCard.name = card.cardName;
        newCard.SetActive(false);
        newCard.GetComponent<CardDisplay>().cardData.cardState= CardState.Deck;
        deck.Add(newCard);
    }

    //洗牌
    public void shuffle(){
        for (int i = 0; i < deck.Count; i++){
            int randomIndex = Random.Range(0, deck.Count);
            GameObject temp = deck[i];
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }
}
