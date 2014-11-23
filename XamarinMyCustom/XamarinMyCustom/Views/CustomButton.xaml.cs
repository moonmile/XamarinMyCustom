using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMyCustom.Views
{
    public partial class CustomButton
    {
        public CustomButton()
        {
            InitializeComponent();

            this.Text = "ボタン";
			this.BackgroundColor = Color.Blue;
        }
    }
}
