using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using static Card;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;

    public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> hand = new List<GameObject>();
    public List<GameObject> discard = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            AddCardToDeck(CardDataBase.allCards[0]);
            AddCardToDeck(CardDataBase.allCards[1]);
        }
        Draw(10);
        shuffle();
        Debug.Log("Deck Size: " + deck.Count);
    }

    // Update is called once per frame
    void Update()
    {
        ShowHand();
    }
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
    public void ShowHand()
    {
        float x = -5,z=-4;
        for(int i = 0;i < hand.Count; i++)
        {
            hand[i].SetActive(true);
            hand[i].transform.position = new Vector3(x, -3, z);
            x += 10/hand.Count;
            z -= 0.01f;
        }
    }
    public void AddCardToDeck(Card card){
        GameObject newCard = Instantiate(cardPrefab);
        newCard.GetComponent<CardDisplay>().cardData = card;
        newCard.name = card.cardName;
        newCard.SetActive(false);
        newCard.GetComponent<CardDisplay>().cardData.cardState= CardState.Deck;
        deck.Add(newCard);
    }

    public void shuffle(){
        for (int i = 0; i < deck.Count; i++){
            int randomIndex = Random.Range(0, deck.Count);
            GameObject temp = deck[i];
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }
}
