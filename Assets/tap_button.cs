using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap_button : MonoBehaviour
{
    public static Card tappedCard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        tappedCard = GetComponent<Card>();
        Debug.Log("カードを取得しました");
    }
}
