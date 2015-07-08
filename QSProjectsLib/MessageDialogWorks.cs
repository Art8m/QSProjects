﻿using System;
using Gtk;

namespace QSProjectsLib
{
	public static class MessageDialogWorks
	{
		public static bool RunQuestionDialog (string question)
		{
			MessageDialog md = new MessageDialog (null,
				                   DialogFlags.Modal,
				                   MessageType.Question,
				                   ButtonsType.YesNo,
				                   question);
			md.SetPosition (WindowPosition.Center);
			md.ShowAll ();
			bool result = md.Run () == (int)ResponseType.Yes;
			md.Destroy ();
			return result;
		}

		public static void RunWarningDialog (string warning)
		{
			MessageDialog md = new MessageDialog (null,
				                   DialogFlags.Modal,
				                   MessageType.Warning,
				                   ButtonsType.Ok,
				                   warning);
			md.SetPosition (WindowPosition.Center);
			md.ShowAll ();
			md.Run ();
			md.Destroy ();
		}
	}
}

