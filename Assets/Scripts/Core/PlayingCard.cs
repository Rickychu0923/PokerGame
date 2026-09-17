using Unity.VisualScripting;

namespace PokerGame.Core
{
    public class PlayingCard
    {
        #region 公開屬性
        public Suit Suit { get; }
        public Rank Rank { get; }
        #endregion 公開屬性

        #region 建構式 //ctrl + d複製
        public PlayingCard(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
        #endregion 建構式
    }
}


