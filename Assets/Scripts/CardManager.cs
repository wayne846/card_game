using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;

    public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> hand = new List<GameObject>();
    public List<GameObject> discard = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        AddCardToDeck(CardDataBase.allCards[0]);
        AddCardToDeck(CardDataBase.allCards[1]);
        AddCardToDeck(CardDataBase.allCards[0]);
        AddCardToDeck(CardDataBase.allCards[1]);
        AddCardToDeck(CardDataBase.allCards[0]);
        AddCardToDeck(CardDataBase.allCards[1]);
        DrawStart();
        shuffle();
        Debug.Log("Deck Size: " + deck.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int DrawStart()
    {
        if (deck.Count > 5)
        {
            for (int i = hand.Count; i < 5; i++)
            {
                hand.Add(deck[0]);
                deck.Remove(deck[0]);
            }
            return 1;
        }
        else return 0;
    }
    public void AddCardToDeck(Card card){
        GameObject newCard = Instantiate(cardPrefab);
        newCard.GetComponent<CardDisplay>().cardData = card;
        newCard.name = card.cardName;
        newCard.SetActive(false);
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
