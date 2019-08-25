using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yomifuda : MonoBehaviour
{
    List<Card> cardList = new List<Card>();
    public void Add(Card _card)
    {
        cardList.Add(_card);
        Text usetext = this.GetComponent<Text>();
        usetext.text = _card.name;
    }
}
