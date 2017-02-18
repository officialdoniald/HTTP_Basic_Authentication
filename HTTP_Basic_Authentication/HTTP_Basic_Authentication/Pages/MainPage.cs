using HTTP_Basic_Authentication.HTTPBasicAuthenticationImplement;
using Xamarin.Forms;

namespace HTTP_Basic_Authentication.Pages
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
           HTTPBasicAuth httpBasicImplement = new HTTPBasicAuth();

            Content = new StackLayout
            {
                Children = {
                    new Label { Text =  httpBasicImplement.GetResponseString("","","")}
                }
            };
        }
        
    }
}
