using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinMyCustom.iOS;

[assembly: Dependency(typeof(DependencyCalcImpl))]
namespace XamarinMyCustom.iOS
{
    class DependencyCalcImpl : IDependencyCalc
    {
        public string GetName()
        {
			// 仮にイベントを発生
			GoEvent();
            return "in iPhone";
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
