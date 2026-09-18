using UnityEngine;
using TMPro;
using PokerGame.Core;

namespace PokerGame.View
{
    public class CardView : MonoBehaviour
    {
        #region UI元件
        [SerializeField]//屬性修飾，強制將私有欄位顯示在編輯器
        private TMP_Text _suitLabel;
        [SerializeField]
        private TMP_Text _rankLabel;
        #endregion UI元件

        #region 公開方法
        public void Bind(PlayingCard card)
        {
            //改文字
            _suitLabel.text = GetSuitText(card.Suit);
            _rankLabel.text = GetRankText(card.Rank);
            //改顏色
            _suitLabel.color = GetSuitColor(card.Suit);
            _rankLabel.color = GetSuitColor(card.Suit);
        }
        #endregion 公開方法

        #region 私有方法
        private string GetRankText(Rank rank) 
        {
            switch (rank)
            {
                case Rank.Ace: return "A";
                case Rank.Jack: return "J";
                case Rank.Queen: return "Q";
                case Rank.King: return "K";
                default: return ((int)rank).ToString();
            }
            
        }
        private string GetSuitText(Suit suit)
        {
            //判斷邏輯式♣,♦,♥,♠
            switch (suit)
            {
                case Suit.Clubs:return "♣";
                case Suit.Diamonds: return "♦";
                case Suit.Hearts: return "♥";
                case Suit.Spades: return "♠";
                default: return "";

            }
        }

        private Color GetSuitColor(Suit suit)
        {
            switch (suit)
            {
                case Suit.Clubs: return Color.black;
                case Suit.Diamonds: return Color.red;
                case Suit.Hearts: return Color.red;
                case Suit.Spades: return Color.black;
                default:return Color.white;

            }

        }

        #endregion 私有方法
    }
}