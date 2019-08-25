using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CardData
{
    public int id;
    public string CardText;
    public string hiragana;

    public CardData(int _id, string _hiragana, string _cardText)
    {
        id = _id;
        hiragana = _hiragana;
        CardText = _cardText;
    }

}
