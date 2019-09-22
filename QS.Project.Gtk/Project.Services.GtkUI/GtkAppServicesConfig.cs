﻿using QS.Permissions;
using QS.Services;
using QS.Validation;
using QS.Validation.GtkUI;

namespace QS.Project.Services.GtkUI
{
	public static class GtkAppServicesConfig
	{
		private static ICommonServices commonServices;
		public static ICommonServices CommonServices {
			get {
				if(commonServices == null) {
					commonServices = new CommonServices(ValidationService, InteractiveService, PermissionService, UserService);
				}
				return commonServices;
			}
		}

		private static IValidationService validationService;
		public static IValidationService ValidationService {
			get {
				if(validationService == null) {
					IValidationViewFactory viewFactory = new GtkValidationViewFactory();
					validationService = new ValidationService(viewFactory);
				}
				return validationService;
			}
		}

		private static IInteractiveService interactiveService;
		public static IInteractiveService InteractiveService {
			get {
				if(interactiveService == null) {
					interactiveService = new GtkInteractiveService();
				}
				return interactiveService;
			}
		}

		private static IPermissionService permissionService;
		public static IPermissionService PermissionService {
			get {
				if(permissionService == null) {
					permissionService = new PermissionService(
						PermissionsSettings.EntityPermissionValidator,
						PermissionsSettings.PresetPermissionValidator
					);
				}
				return permissionService;
			}
		}

		private static IUserService userService;
		public static IUserService UserService {
			get {
				if(userService == null) {
					userService = new UserService();
				}
				return userService;
			}
		}
	}
}
