using System;
using Gtk;
using ServiceStack.ServiceClient.Web;
using HelloDto;

public partial class MainWindow: Window
{	
    public MainWindow(): base (WindowType.Toplevel)
    {
        Build();
        Default = SubmitButton;
        SubmitButton.Clicked += HandleClicked;
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
    }

    void Append(string text)
    {
        OutputTextView.Buffer.InsertAtCursor(text + Environment.NewLine);
    }
	
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
