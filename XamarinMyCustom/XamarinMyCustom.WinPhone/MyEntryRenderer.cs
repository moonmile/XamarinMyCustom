using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinMyCustom.Views;
using Xamarin.Forms.Platform.WinPhone;
using XamarinMyCustom.WinPhone;
using System.Windows.Controls;
using System.Windows.Media;


[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]

namespace XamarinMyCustom.WinPhone
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {   // perform initial setup
                // lets get a reference to the native control
                var nativeEditText = (System.Windows.Controls.Grid)Control;
                // do whatever you want to the textField here!
				nativeEditText.Background = new SolidColorBrush(System.Windows.Media.Colors.Blue);
            }
        }
    }

	public class MyLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			if (e.OldElement == null)
			{
				// 初回のみ
				var text1 = (TextBlock)this.Control;
				text1.Tap += (s, ee) =>
				{
					var t = e.NewElement as MyLabel;
					t.OnTapped(t, null);
				};
			}
		}
	}
}
