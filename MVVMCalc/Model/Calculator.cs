using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace MVVMCalc.Model
{
    public class Calculator
    {
        private static readonly Dictionary<CalculateType, Func<double, double, double>> calcMap = new
            Dictionary<CalculateType, Func<double, double, double>>
            {
                {
                    CalculateType.None, (x, y) =>
                    {
                        throw new InvalidOperationException();
                    }
                },
                {
                    CalculateType.Add,(x,y) =>x+y
                },
                {
                    CalculateType.Sub,(x,y)=>x-y
                },
                {
                    CalculateType.Mul,(x,y)=>x*y
                },
                {
                    CalculateType.Div,(x,y)=>x/y
                }
            };

        /// <summary> 
        /// 渡された値の指定された計算結果を返す。 
        /// opにCalculateType.Noneを渡すとInvalidOperationExceptionをスローします。 
        /// </summary> 
        /// <param name="x">左辺値</param> 
        /// <param name="y">右辺値</param> 
        /// <param name="op">計算方法</param> 
        /// <returns>計算結果</returns> 
        public double Execute(double x, double y, CalculateType op)
        {
            return calcMap[op](x, y);
        }
    }
}