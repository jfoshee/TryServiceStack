
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label NameLabel;
	private global::Gtk.Entry NameField;
	private global::Gtk.Button SubmitButton;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.NameLabel = new global::Gtk.Label ();
		this.NameLabel.Name = "NameLabel";
		this.NameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter your name");
		this.vbox1.Add (this.NameLabel);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.NameLabel]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.NameField = new global::Gtk.Entry ();
		this.NameField.CanFocus = true;
		this.NameField.Name = "NameField";
		this.NameField.Text = global::Mono.Unix.Catalog.GetString ("World");
		this.NameField.IsEditable = true;
		this.NameField.InvisibleChar = '●';
		this.vbox1.Add (this.NameField);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.NameField]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.SubmitButton = new global::Gtk.Button ();
		this.SubmitButton.CanFocus = true;
		this.SubmitButton.Name = "SubmitButton";
		this.SubmitButton.UseUnderline = true;
		this.SubmitButton.Label = global::Mono.Unix.Catalog.GetString ("Submit");
		this.vbox1.Add (this.SubmitButton);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.SubmitButton]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}