
// This file has been generated by the GUI designer. Do not modify.
namespace Gamma.Widgets.SidePanels
{
	public partial class LeftSidePanel
	{
		private global::Gtk.HBox hboxMain;

		private global::Gtk.EventBox eventboxArrow;

		private global::Gtk.VBox vbox4;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Arrow arrowSlider;

		private global::Gtk.Label labelTitle;

		private global::Gtk.VSeparator vseparator2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Gamma.Widgets.SidePanels.LeftSidePanel
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Gamma.Widgets.SidePanels.LeftSidePanel";
			// Container child Gamma.Widgets.SidePanels.LeftSidePanel.Gtk.Container+ContainerChild
			this.hboxMain = new global::Gtk.HBox();
			this.hboxMain.Name = "hboxMain";
			this.hboxMain.Spacing = 6;
			// Container child hboxMain.Gtk.Box+BoxChild
			this.eventboxArrow = new global::Gtk.EventBox();
			this.eventboxArrow.Name = "eventboxArrow";
			// Container child eventboxArrow.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.vbox4.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vseparator1]));
			w1.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.arrowSlider = new global::Gtk.Arrow(((global::Gtk.ArrowType)(3)), ((global::Gtk.ShadowType)(2)));
			this.arrowSlider.Name = "arrowSlider";
			this.vbox4.Add(this.arrowSlider);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.arrowSlider]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.labelTitle = new global::Gtk.Label();
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.LabelProp = global::Mono.Unix.Catalog.GetString("Панель");
			this.labelTitle.SingleLineMode = true;
			this.labelTitle.Angle = 90D;
			this.vbox4.Add(this.labelTitle);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.labelTitle]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.Name = "vseparator2";
			this.vbox4.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.vseparator2]));
			w4.Position = 3;
			this.eventboxArrow.Add(this.vbox4);
			this.hboxMain.Add(this.eventboxArrow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hboxMain[this.eventboxArrow]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.hboxMain);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.eventboxArrow.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler(this.OnEventboxArrowButtonPressEvent);
		}
	}
}
