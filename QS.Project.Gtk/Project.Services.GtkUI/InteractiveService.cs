﻿using QS.Dialog;
using QS.Dialog.GtkUI;
using QS.Services;

namespace QS.Project.Services.GtkUI
{
	public class GtkInteractiveService : IInteractiveService
	{
		private IInteractiveMessage interactiveMessage;
		public IInteractiveMessage InteractiveMessage {
			get {
				if(interactiveMessage == null) {
					interactiveMessage = new GtkMessageDialogsInteractive();
				}
				return interactiveMessage;
			}
		}

		private IInteractiveQuestion interactiveQuestion;
		public IInteractiveQuestion InteractiveQuestion {
			get {
				if(interactiveQuestion == null) {
					interactiveQuestion = new GtkQuestionDialogsInteractive();
				}
				return interactiveQuestion;
			}
		}
	}
}
