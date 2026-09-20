using System.Collections.Generic;
using PokerGame.Core;
using PokerGame.View;
using UnityEngine;

namespace PokerGame.Game 
{
    /// <summary>
    /// 荷官:負責牌組資料調度
    /// </summary>
    public class Dealer : MonoBehaviour
    {
        #region 公開欄位
        /// <summary>
        /// 交給荷官的牌面物件池
        /// </summary>
        public CardViewPool viewPool;
        #endregion 公開欄位

        #region 私有欄位
        /// <summary>
        /// 建立整副牌
        /// </summary>
        private readonly Deck _deck = new Deck();
        /// <summary>
        /// 資料對應的卡牌視覺 
        /// </summary>
        private readonly List<CardView> _activeViews = new List<CardView>();
        #endregion 私有欄位
   

        #region 生命週期
        /// <summary>
        /// 比start更早執行
        /// </summary>
        private void Awake()
        {
            viewPool.Initialize(52);
        }
        # endregion 生命週期

        #region 公開方法
        /// <summary>
        /// 開始回合:回收牌，洗牌
        /// </summary>
        public void BeginRound()
        {
            _deck.Reset();
            _deck.Shuffle();
        }
        /// <summary>
        /// 發牌給某人
        /// </summary>
        /// <returns></卡牌資料>
        public PlayingCard DealTo() 
        { 
            PlayingCard card = _deck.Draw();

            return card;
        }
        #endregion 公開方法
    }
}

