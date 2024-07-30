using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject cardPrefab;

    public List<GameObject> deck = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        AddCardToDeck(CardDataBase.allCards[0]);
        AddCardToDeck(CardDataBase.allCards[1]);
        AddCardToDeck(CardDataBase.allCards[0]);
        AddCardToDeck(CardDataBase.allCards[1]);
        AddCardToDeck(CardDataBase.allCards[0]);
        AddCardToDeck(CardDataBase.allCards[1]);

        shuffle();
        Debug.Log("Deck Size: " + deck.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCardToDeck(Card card){
        GameObject newCard = Instantiate(cardPrefab);
        newCard.GetComponent<CardDisplay>().cardData = card;
        newCard.name = card.cardName;
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
