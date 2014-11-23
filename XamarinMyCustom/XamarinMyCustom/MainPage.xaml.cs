using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace XamarinMyCustom
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnClickSample(object sender, EventArgs e)
        {
            var page = new SampleButtonPage();
            this.Navigation.PushAsync(page);
        }
        void OnClickDependency(object sender, EventArgs e)
        {
            var page = new SampleDependency();
            this.Navigation.PushAsync(page);
        }
        void OnClickRenderer(object sender, EventArgs e)
        {
            var page = new SampleMyRenderer();
            this.Navigation.PushAsync(page);
        }
    }
}
