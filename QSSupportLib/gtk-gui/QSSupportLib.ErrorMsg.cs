
// This file has been generated by the GUI designer. Do not modify.
namespace QSSupportLib
{
	public partial class ErrorMsg
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Image image249;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label labelUserMessage;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Expander expander1;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TextView textviewError;
		
		private global::Gtk.Label GtkLabel1;
		
		private global::Gtk.Button buttonCopy;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSSupportLib.ErrorMsg
			this.Name = "QSSupportLib.ErrorMsg";
			this.Title = global::Mono.Unix.Catalog.GetString ("Ошибка");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-error", global::Gtk.IconSize.Menu);
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Internal child QSSupportLib.ErrorMsg.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.image249 = new global::Gtk.Image ();
			this.image249.Name = "image249";
			this.image249.Xalign = 0F;
			this.image249.Yalign = 0F;
			this.image249.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-error", global::Gtk.IconSize.Dialog);
			this.hbox1.Add (this.image249);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.image249]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("К сожалению в программе произошла непредвиденная ошибка.");
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelUserMessage = new global::Gtk.Label ();
			this.labelUserMessage.Name = "labelUserMessage";
			this.labelUserMessage.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.labelUserMessage.Wrap = true;
			this.labelUserMessage.Selectable = true;
			this.vbox2.Add (this.labelUserMessage);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelUserMessage]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Вы можете помочь нам улучшить программу, сообщив нам об ошибке.\nДля этого отправьте на адрес info@qsolution.ru, сообщение с \nуказанием следующей информации:\n* Название программы и версия\n* Какие действия приводять к возникновению ошибки\n* Техническое сообщение об ошибке ");
			this.vbox2.Add (this.label3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label3]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.expander1 = new global::Gtk.Expander (null);
			this.expander1.CanFocus = true;
			this.expander1.Name = "expander1";
			// Container child expander1.Gtk.Container+ContainerChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.HeightRequest = 203;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewError = new global::Gtk.TextView ();
			this.textviewError.CanFocus = true;
			this.textviewError.Name = "textviewError";
			this.textviewError.Editable = false;
			this.GtkScrolledWindow.Add (this.textviewError);
			this.expander1.Add (this.GtkScrolledWindow);
			this.GtkLabel1 = new global::Gtk.Label ();
			this.GtkLabel1.Name = "GtkLabel1";
			this.GtkLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("Техническая информация");
			this.GtkLabel1.UseUnderline = true;
			this.expander1.LabelWidget = this.GtkLabel1;
			this.vbox2.Add (this.expander1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.expander1]));
			w8.Position = 3;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w9.Position = 1;
			w1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox1]));
			w10.Position = 0;
			// Internal child QSSupportLib.ErrorMsg.ActionArea
			global::Gtk.HButtonBox w11 = this.ActionArea;
			w11.Name = "dialog1_ActionArea";
			w11.Spacing = 10;
			w11.BorderWidth = ((uint)(5));
			w11.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCopy = new global::Gtk.Button ();
			this.buttonCopy.TooltipMarkup = "Копирует сообщение в буфер обмена.";
			this.buttonCopy.CanFocus = true;
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.UseUnderline = true;
			this.buttonCopy.Label = global::Mono.Unix.Catalog.GetString ("Скопировать");
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-copy", global::Gtk.IconSize.Menu);
			this.buttonCopy.Image = w12;
			w11.Add (this.buttonCopy);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonCopy]));
			w13.Expand = false;
			w13.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString ("Понятно");
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.Menu);
			this.buttonOk.Image = w14;
			this.AddActionWidget (this.buttonOk, -7);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w11 [this.buttonOk]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 536;
			this.DefaultHeight = 280;
			this.Show ();
			this.buttonCopy.Clicked += new global::System.EventHandler (this.OnButtonCopyClicked);
		}
	}
}
