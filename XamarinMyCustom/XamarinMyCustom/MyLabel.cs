using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMyCustom.Views
{
	/// <summary>
	/// タップ機能つきのラベル
	/// </summary>
	public class MyLabel : Label
	{
		public event Action<object, object> Tapped;
		public void OnTapped( object sender, EventArgs e ) {
			if ( Tapped != null ) {
				Tapped( sender, e );
			}
		}
	}
}
