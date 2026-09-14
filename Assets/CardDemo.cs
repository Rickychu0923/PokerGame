using UnityEngine;
using PokerGame.Core;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public PlayingCard testCard = new PlayingCard();

    //初始化
    void Start()
    {
        Debug.Log(testCard.suit + testCard.face);
    }

    //每一FPS 執行一次
    void Update()
    {
        
    }
}
