using UnityEngine;
using PokerGame.Core;
using PokerGame.View;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public PlayingCard testCard = new PlayingCard(Suit.Spades, Rank.Ace);
    public CardView cardView;
    /// <summary>
    /// 建立整副牌
    /// </summary>
    private Deck _deck = new Deck();
    //初始化
    void Start()
    {
        //Debug.Log(testCard.CardInfo());
        testCard = _deck.Draw();
        
    }

    //每一FPS 執行一次
    void Update()
    {
        //視覺顯示綁定資料
        cardView.Bind(testCard);
    }
}
