using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class GameMaster : MonoBehaviour
{
    public GameObject cardPrefab;
    public Field field;
    public Yomifuda yomifuda;
    private GameObject[] buttons;
    [SerializeField] EventSystem eventSystem;

    enum Phase
    {
        STANDBY,
        PLAY,
        END,
    };

    Phase phase;

    void Start()
    {
        phase = Phase.STANDBY;
    }
    void Update()
    {
        switch (phase)
        {
            case Phase.STANDBY:
                StandByPhase();
                break;
            case Phase.PLAY:
                PlayPhase();
                break;
            case Phase.END:
                EndPhase();
                break;
            default:
                break;
        }
    }

    public List<CardData> karutaList = new List<CardData>()
    {
        new CardData(0,"あ","text0"),
        new CardData(1,"い","text1"),
        new CardData(2,"う","text2"),
        new CardData(3,"え","text3"),
        new CardData(4,"お","text4"),
        new CardData(5,"か","text5"),
        new CardData(6,"き","text6"),
        new CardData(7,"く","text7"),
        new CardData(8,"け","text8"),
        new CardData(9,"こ","text9"),
    };

    void StandByPhase() //カードを生成して場にだす
    {
        Debug.Log("StandByPhase"); 
        Shuffle();
        for (int i = 0; i < 5; i++)
        {
            GameObject cardObj = Instantiate(cardPrefab);
            cardObj.name = karutaList[i].CardText;

            Card card = cardObj.GetComponent<Card>();
            card.Load(karutaList[i]);
            field.Add(card);
        }
        phase = Phase.PLAY;
    }
    void PlayPhase() //場に出たカードをクリックしてそれが選んだテキストとあっていれば次へ間違いならそのまま
    {
        Debug.Log("PlayPhase");

        Card questioncard = field.SelectCard();
        yomifuda.Add(questioncard);
        Debug.Log("ボタン");



        
        phase = Phase.END;
    }
    void EndPhase()
    {

    }






    void Shuffle()
    {
        for(int i = 0; i < karutaList.Count; i++)
        {
            CardData temp = karutaList[i];
            int RandomIndex = Random.Range(0, karutaList.Count);
            karutaList[i] = karutaList[RandomIndex];
            karutaList[RandomIndex] = temp;
        }
    }
    public void TapButton(Card _card)
    {
        
        if(eventSystem == _card)
        {
            field.Pull(_card);
        }
        else
        {
            Debug.Log("ミス");
        }
    }
}
