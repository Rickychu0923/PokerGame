using System;
using Unity.VisualScripting;

namespace PokerGame.Core
{
    [Serializable]//請系統預先序列化(非Monobehavior也看的到資料)
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

        #region 公開方法
        /// <summary>
        /// 回傳樸克牌花色和點數
        /// </summary>
        /// <returns>花色+數值</returns>
        public string CardInfo()
        {
            return Rank.ToString() + " of " + Suit.ToString();
        }
        # endregion 公開方法


    }

}


