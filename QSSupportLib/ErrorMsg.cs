using System;
using Gtk;
using QSProjectsLib;
using System.Text.RegularExpressions;
using NLog;
using System.Linq;
using NLog.Targets;

namespace QSSupportLib
{
	public partial class ErrorMsg : Gtk.Dialog
	{
		private static Logger logger = LogManager.GetCurrentClassLogger ();
		Exception AppExpeption;
		string message;

		public ErrorMsg (Window parent, Exception ex, string userMessage)
		{
			if (parent != null)
				this.Parent = parent;
			this.Build ();

			AppExpeption = ex;
			message = userMessage;
			labelUserMessage.LabelProp = userMessage;
			labelUserMessage.Visible = userMessage != "";
			textviewError.Buffer.Text = ex.ToString ();
			buttonSendReport.Sensitive = false;
			entryEmail.Text = QSMain.User.Email;

			this.SetPosition (WindowPosition.CenterOnParent);

			textviewDescription.Buffer.Changed += InputsChanged;
			entryEmail.Changed += InputsChanged;
		}

		void InputsChanged (object sender, EventArgs e)
		{
			var regex = new Regex (@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
			buttonSendReport.Sensitive = 
				(!String.IsNullOrWhiteSpace (textviewDescription.Buffer.Text) && regex.IsMatch (entryEmail.Text));
			if (sender is Gtk.Entry) {
				if (!regex.IsMatch (entryEmail.Text))
					(sender as Gtk.Entry).ModifyText (Gtk.StateType.Normal, new Gdk.Color (255, 0, 0));
				else
					(sender as Gtk.Entry).ModifyText (Gtk.StateType.Normal);
			}
		}

		protected void OnButtonCopyClicked (object sender, EventArgs e)
		{
			Clipboard clipboard = Clipboard.Get (Gdk.Atom.Intern ("CLIPBOARD", false));

			string TextMsg = String.Format ("Продукт: {0}\nВерсия: {1}\nРедакция: {2}\nОшибка: {4}\n{3}", 
				                 MainSupport.ProjectVerion.Product, 
				                 MainSupport.ProjectVerion.Version,
				                 MainSupport.ProjectVerion.Edition,
				                 AppExpeption,
				                 message
			                 );
			clipboard.Text = TextMsg;
			clipboard.Store ();
		}

		protected void OnButtonSendReportClicked (object sender, EventArgs e)
		{
			var svc = QSBugReporting.ReportWorker.GetReportService ();
			if(svc == null)
			{
				MessageDialogWorks.RunErrorDialog ("Не удалось установить соединение с сервером Quality Solution.");
				return;
			}
			string logFileName = GetLogFile ();
			string logContent = String.Empty;
			if(!String.IsNullOrWhiteSpace (logFileName))
			{
				try
				{
					logContent = System.IO.File.ReadAllText(logFileName);
				}
				catch(Exception ex)
				{
					logger.Error (ex, "Не смогли прочитать лог файл {0}, для отправки.");
				}
			}

			//FIXME Костыль из за бага в mono.
			logContent = logContent.Replace ("=", "≡");
				
			var result = svc.SubmitBugReport (MainSupport.ProjectVerion.Product,
				             MainSupport.ProjectVerion.Version.ToString (), 
							 String.Format ("{0}{1}", 
					String.IsNullOrWhiteSpace (message) ? String.Empty : String.Format ("Пользовательское сообщение:{0}\n", message.Replace ("=", "≡")),
					AppExpeption.ToString ().Replace ("=", "≡")),
				textviewDescription.Buffer.Text.Replace ("=", "≡"),
				             entryEmail.Text,
							 QSMain.User.Name,
							 logContent
			);
			if (result) {
				this.Respond (ResponseType.Ok);
			} else
				MessageDialogWorks.RunWarningDialog ("Отправка сообщения не удалась.\n" +
				"Проверьте ваше интернет соединение и повторите попытку. Если отправка неудастся возможно имеются проблемы на стороне сервера.");
		}
			
		private string GetLogFile()
		{
			var fileTarget = LogManager.Configuration.AllTargets.FirstOrDefault(t => t is FileTarget) as FileTarget;
			return fileTarget == null ? string.Empty : fileTarget.FileName.Render(new LogEventInfo { Level = LogLevel.Debug });
		}
	}
}