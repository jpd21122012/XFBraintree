using XFBraintree.ViewModels;
using Xamarin.Forms;

namespace XFBraintree.Views
{
    public partial class PaymentPage : ContentPage
    {
        public PaymentPage()
        {
            InitializeComponent();
            BindingContext = new PaymentPageViewModel();
        }
    }
}
