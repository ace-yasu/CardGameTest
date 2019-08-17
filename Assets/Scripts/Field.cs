using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Field : MonoBehaviour
{

    public List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        _card.transform.SetParent(this.transform, false);
        cardList.Add(_card);
    }

    public Card Pull(Card _card)
    {
        cardList.Remove(_card);
        return _card;
    }

    public Card SelectCard()
    {
        Card card = cardList[Random.Range(0, cardList.Count)];
        return card;
    }
}
