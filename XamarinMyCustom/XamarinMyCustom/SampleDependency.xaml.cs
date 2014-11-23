using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMyCustom
{
    public partial class SampleDependency
    {

        IDependencyCalc _dep = null;

        public SampleDependency()
        {
            InitializeComponent();

            _dep = DependencyService.Get<IDependencyCalc>();
			if (_dep != null)
			{
				/// イベントを拾う
				_dep.LocalEvent += _dep_LocalEvent;
			}
        }

        void OnClickEvent(object sender, EventArgs e)
        {
            // プラットフォームの名前を取得
            this.text1.Text = _dep.GetName();
        }

        void _dep_LocalEvent(object sender, int i)
        {
			this.text2.Text = string.Format("clicked {0}", i);
        }

    }
}
