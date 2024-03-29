﻿using System;
using System.Collections.Generic;
using System.Security.Permissions;
using MVVMCalc.Common;
using MVVMCalc.Model;

namespace MVVMCalc.ViewModel
{
    public class CalculateTypeViewModel:ViewModelBase
    {
        /// <summary>
        /// 計算方法
        /// </summary>
        public CalculateType CalculateType { get; }

        public string Label { get; }

        /// <summary> 
        /// 計算方法と表示名を設定してインスタンスを生成します。 
        /// </summary> 
        /// <param name="calculateType">計算方法</param> 
        /// <param name="label">表示名</param> 
        public CalculateTypeViewModel(CalculateType calculateType, string label)
        {
            this.CalculateType = calculateType;
            this.Label = label;
        }

        /// <summary> 
        /// CalculateTypeの値と表示用ラベルのマップ 
        /// </summary> 
        private static Dictionary<CalculateType,string> typeLableMap = new Dictionary<CalculateType, string>()
        {
            {CalculateType.None,"未選択" },
            {CalculateType.Add,"足し算" },
            {CalculateType.Sub,"引き算" },
            {CalculateType.Mul,"掛け算" },
            {CalculateType.Div,"割り算" }
        };

        /// <summary> 
        /// 計算方法からラベル名を自動的に引き当ててCalculateTypeViewModelのインスタンスを生成する。 
        /// </summary> 
        /// <param name="type">計算方法</param> 
        /// <returns>生成されたインスタンス</returns> 
        public static CalculateTypeViewModel Create(CalculateType type)
        {
            return new CalculateTypeViewModel(type,typeLableMap[type]);
        }

        /// <summary> 
        /// CalculateTypeの全値に対応するCalculateTypeViewModelを作成する。 
        /// </summary> 
        /// <returns>生成されたインスタンス</returns>
        public static IEnumerable<CalculateTypeViewModel> Create()
        {
            foreach (CalculateType e  in Enum.GetValues(typeof(CalculateType)))
            {
                yield return Create(e);
            }
        }
    }
}