using UnityEngine;
using PokerGame.Core;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public PlayingCard testCard = new PlayingCard(Suit.Spades, Rank.Ace);

    //初始化
    void Start()
    {
        Debug.Log(testCard.CardInfo());
    }

    //每一FPS 執行一次
    void Update()
    {
        
    }
}
