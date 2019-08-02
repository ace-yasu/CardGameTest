using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public Text cardText;
    string hiragana;

    public void Load(CardData _cardData)
    {
        cardText.text = _cardData.CardText;
        hiragana = _cardData.hiragana;
    }
}
