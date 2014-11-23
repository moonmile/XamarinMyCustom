using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMyCustom
{
    /// <summary>
    /// DependencyService を利用して各種プラットフォームの独自関数を呼び出す
    /// いわゆるインターフェースで戻すだけ。
    /// </summary>
    public interface IDependencyCalc
    {
        /// <summary>
        /// プラットフォームから名前を返す
        /// </summary>
        /// <returns></returns>
        string GetName();
        /// <summary>
        /// 数値イベントを発生させる
        /// </summary>
        event EventHandler<int> LocalEvent;
    }
}
