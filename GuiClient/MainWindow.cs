using System;
using Gtk;
using ServiceStack.ServiceClient.Web;
using HelloDto;

public partial class MainWindow: Gtk.Window
{	
    public MainWindow(): base (Gtk.WindowType.Toplevel)
    {
        Build();
        SubmitButton.Clicked += HandleClicked;
    }

    void HandleClicked(object sender, EventArgs e)
    {
        var name = NameField.Text;
        var client = new JsonServiceClient("http://127.0.0.1:8080/servicestack");
        var response = client.Send<HelloResponse>(new Hello { Name = name });
        NameLabel.LabelProp = response.Result;
    }
	
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
