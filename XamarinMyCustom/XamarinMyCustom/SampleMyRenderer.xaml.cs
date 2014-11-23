using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinMyCustom
{
    public partial class SampleMyRenderer
    {
        public SampleMyRenderer()
        {
            InitializeComponent();

			this.label1.Tapped += label1_Tapped;
        }

		void label1_Tapped(object arg1, object arg2)
		{
			label1.Text = "tapped !!!";
		}
    }
}
