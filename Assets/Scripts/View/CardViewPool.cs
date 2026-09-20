using System;
using System.Collections.Generic;
using UnityEngine;

namespace PokerGame.View
{
    /// <summary>
    /// 牌面物件池:建立集中、租用與歸還的管理系統
    /// </summary>
    public class CardViewPool : MonoBehaviour
    {
        #region Unity欄位
        [SerializeField]//卡牌面預制物件
        [Header("牌面元件/預置物")]
        private CardView _cardPrefab;
        #endregion Unity欄位

        #region 私有欄位
        private readonly Queue<CardView> _cardViews = new Queue<CardView>();   
        #endregion 私有欄位


        #region 公開方法
        public void Initialize(int size)
        {
            for(int index = 0; index < size; index++)
            {
                //具現化物見到指定父物件下
                CardView tempView = Instantiate(_cardPrefab, transform);
                tempView.gameObject.SetActive(false);
                _cardViews.Enqueue(tempView);
            }
        }
        #endregion 公開方法

        

    }
}


