using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinMyCustom.Droid;

[assembly: Dependency(typeof(DependencyCalcImpl))]
namespace XamarinMyCustom.Droid
{
    class DependencyCalcImpl : IDependencyCalc
    {
        public string GetName()
        {
			// 仮にイベントを発生
			GoEvent();
			// ここの処理は機種により異なる
			return "in Android";
        }

        public event EventHandler<int> LocalEvent;

        int _i = 0;
        public void GoEvent()
        {
            if (LocalEvent != null)
            {
                LocalEvent(this, _i);
                _i++;
            }
        }
    }
}
