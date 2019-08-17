using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_button : MonoBehaviour
{
    public static Card tappedCard;

    public void OnClick()
    {
        tappedCard = GetComponent<Card>();
        Debug.Log("カードを取得しました");
    }
}
