using System;
using System.Collections.Generic;

namespace PokerGame.Core
{
    /// <summary>
    /// 保存一副標準樸克牌
    /// 可重置，洗牌，抽牌
    /// </summary>

    public class Deck
    {
        #region 公有方法
        public void Reset()
        {
            _nextIndex = 0;
        }
        /// <summary>
        /// Fisher-Yates 經典洗牌演算法
        /// </summary>
        public void Shuffle()
        {
            for (int index = _cards.Count; index > 0; index--)
            {
                //最大值不會被random出來
                int swapIndex = _random.Next(0,index);
                //暫存牌庫最後一張牌
                PlayingCard tempCard = _cards[index - 1];
                //抽出的牌放到最後
                _cards[index - 1] = _cards[swapIndex];
                //完成交換
                _cards[swapIndex] = tempCard;
            }
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
            Reset();
        }
        # endregion 建構式

        #region 私有欄位
        private readonly List<PlayingCard> _cards = new List<PlayingCard>();
        /// <summary>
        /// 內建的隨機數
        /// </summary>
        private readonly Random _random = new Random();
        private int _nextIndex; 
        #endregion 私有欄位

        #region 公開屬性
            /// <summary>
            /// 呼叫參數時會即時更新算式結果(=>)
            /// </summary>
            public int Remaining => _cards.Count - _nextIndex; 
            /// <summary>
            /// 牌庫是否為空
            /// </summary>
            public bool IsEmpty => Remaining == 0;

        #endregion 公開屬性
    }
}
