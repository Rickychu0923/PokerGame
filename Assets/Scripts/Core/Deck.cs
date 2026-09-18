using System;
using System.Collections.Generic;

namespace PokerGame.Core
{
    /// <summary>
    /// 保存一副標準樸克牌
    /// </summary>

    public class Deck
    {
        #region 公有方法
        public void Reset()
        {
            _nextIndex = 0;
        }
        public void Shuffle()
        {

        }
        public PlayingCard Draw()
        {
            
            return _cards[_nextIndex++];
        }
        #endregion 公有方法

        #region 私有方法
        /// <summary>
        /// 創建一組標準卡牌
        /// </summary>
        private void CreateStandardDeck()
        {
            //遍歷四個花色
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                //遍歷所有點數
                foreach(Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    //記錄到清單上
                    _cards.Add(new PlayingCard(suit, rank));
                }
            }
        }


        #endregion 私有方法

        #region 建構式
        public Deck() 
        {
            CreateStandardDeck();
        }
        # endregion 建構式

        #region 私有欄位
        private readonly List<PlayingCard> _cards = new List<PlayingCard>();
        private int _nextIndex; 
        #endregion 私有欄位

        #region 公開屬性
        #endregion 公開屬性
    }
}
