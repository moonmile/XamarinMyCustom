using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinMyCustom.Views;
using XamarinMyCustom.Droid;


[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]

namespace XamarinMyCustom.Droid
{
    public class MyEntryRenderer : EntryRenderer
    {
        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {   // perform initial setup
                // lets get a reference to the native control
                var nativeEditText = (global::Android.Widget.EditText)Control;
                // do whatever you want to the textField here!
                nativeEditText.SetBackgroundColor(global::Android.Graphics.Color.Red);
            }
        }
    }

	/// <summary>
	/// ラベルのタップイベントを Xamarin.Forms にコールバックする
	/// </summary>
	public class MyLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			if (e.OldElement == null)
			{
				// 初回のみ
				var text1 = (global::Android.Widget.TextView)this.Control;
				text1.Click += (s, ee) =>
				{
					var t = e.NewElement as MyLabel;
					t.OnTapped(t, null);
				};
			}
		}
	}
}
