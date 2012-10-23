using System;
using MonoTouch.UIKit;
using ServiceStack.ServiceClient.Web;
using HelloDto;

namespace iPadClient
{
    public partial class iPadClientViewController : UIViewController
    {
        public iPadClientViewController() : base ("iPadClientViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NameField.Text = "World";
            OutputText.Text = String.Empty;
            SubmitButton.TouchUpInside += HandleClicked;
        }

        void HandleClicked(object sender, EventArgs e)
        {
            var name = NameField.Text;
            var client = new JsonServiceClient("http://127.0.0.1:8080/servicestack");
            client.SendAsync<HelloResponse>(
                new Hello { Name = name }, 
                (response) => Append(response.Result),
                (response, error) => Append("ERROR: " + error.Message)
            );
            NameField.ResignFirstResponder();
        }
        
        void Append(string text)
        {
            InvokeOnMainThread(() =>
               OutputText.Text += text + Environment.NewLine);
        }

        public override void ViewDidUnload()
        {
            base.ViewDidUnload();
            ReleaseDesignerOutlets();
        }
    }
}

