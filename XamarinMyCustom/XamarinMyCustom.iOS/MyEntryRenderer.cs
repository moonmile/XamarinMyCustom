using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinMyCustom.Views;
using Xamarin.Forms.Platform.iOS;
using XamarinMyCustom.WinPhone;
using MonoTouch.Foundation;
using MonoTouch.UIKit;


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
                var nativeEditText = (UITextField)Control;
                // do whatever you want to the textField here!
				nativeEditText.BackgroundColor = UIColor.Green;
            }
        }
    }

	public class MyLabelRenderer : LabelRenderer
	{
		UITapGestureRecognizer tgr = new UITapGestureRecognizer();

		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			if (e.OldElement == null)
			{
				// 初回のみ
				var text1 = (UILabel)this.Control;
				var tgr = new UITapGestureRecognizer(() => {
					var t = e.NewElement as MyLabel;
					t.OnTapped(t, null);
				});
				text1.UserInteractionEnabled = true;
				text1.AddGestureRecognizer(tgr);
			}
		}
	}
}
