using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DateCellPage : ViewCell
    {
        public static readonly BindableProperty LabelTextProperty=
            BindableProperty.Create("LabelText", typeof(string),typeof(DateCellPage));
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }
        public DateCellPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}