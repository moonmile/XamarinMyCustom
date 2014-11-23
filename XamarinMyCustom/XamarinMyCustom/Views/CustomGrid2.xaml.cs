using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamarinMyCustom.Views
{
    /// <summary>
    /// Xamarin.Forms の部品だけで作るカスタムコントロール
    /// Grid のようなコンテナを継承して部品を作る
    /// </summary>
    public partial class CustomGrid2
    {
        public CustomGrid2()
        {
            InitializeComponent();

			// 縦横を動的に作成する
			for (int i = 0; i < 5; i++ ) 
				this.ColumnDefinitions.Add(new ColumnDefinition() { Width = 80 });
			for (int i = 0; i < 3; i++)
				this.RowDefinitions.Add(new RowDefinition() { Height = 80 });
			// var isrc = StreamImageSource.FromResource("XamarinMyCustom.Resources.pronama-chan-100.png");
			for (int r = 0; r < 3; r++)
			{
				for (int c = 0; c < 5; c++)
				{
					var btn = new Button() { Text = string.Format("{0},{1}", c,r )};
					this.Children.Add(btn, c, r);
					// ボタンをクリックしたときのイベント
					btn.Clicked += (s, e) => { ((Button)s).Opacity = 0.0; };
				}
			}
		}
    }
}
