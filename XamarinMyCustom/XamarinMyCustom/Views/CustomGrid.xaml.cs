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
    public partial class CustomGrid
    {
        public CustomGrid()
        {
            InitializeComponent();

			// リソースから貼り付け
			this.img1.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.pronama-chan-100.png"); ;
			this.img2.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.anzu-chan-100.png"); ;
			this.img3.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.claudia-san-100.png"); ;
			this.img4.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.conoha-chan-100.png"); ;
			this.img5.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.query-chan-100.png"); ;
			this.img6.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.unity-chan-100.png"); ;
			this.img7.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.pronama-chan-100.png"); ;
			this.img8.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.anzu-chan-100.png"); ;
			this.img9.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.claudia-san-100.png"); ;
			this.img10.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.conoha-chan-100.png"); ;
			this.img11.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.query-chan-100.png"); ;
			this.img12.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.unity-chan-100.png"); ;
			this.img13.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.pronama-chan-100.png"); ;
			this.img14.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.anzu-chan-100.png"); ;
			this.img15.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.claudia-san-100.png"); ;
			this.img16.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.conoha-chan-100.png"); ;
			this.img17.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.query-chan-100.png"); ;
			this.img18.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.unity-chan-100.png"); ;
			this.img19.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.pronama-chan-100.png"); ;
			this.img20.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.anzu-chan-100.png"); ;
			this.img21.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.claudia-san-100.png"); ;
			this.img22.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.conoha-chan-100.png"); ;
			this.img23.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.query-chan-100.png"); ;
			this.img24.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.unity-chan-100.png"); ;
			this.img25.Source = StreamImageSource.FromResource("XamarinMyCustom.Resources.pronama-chan-100.png"); ;
		}  
    }
}
