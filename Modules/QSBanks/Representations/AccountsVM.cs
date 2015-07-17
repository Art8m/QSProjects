﻿using System;
using System.Collections.Generic;
using Gtk;
using Gtk.DataBindings;
using NHibernate.Transform;
using QSBanks;
using QSOrmProject;
using QSOrmProject.RepresentationModel;

namespace Vodovoz.ViewModel
{

	//!!!! Набросок, начал делать и решил отложить не рабочий код.
	public class AccountsVM : RepresentationModelBase<AccountsVM, AccountsVMNode>
	{
		public IUnitOfWorkGeneric<IAccountOwner> CounterpartyUoW {
			get {
				return UoW as IUnitOfWorkGeneric<IAccountOwner>;
			}
		}

		#region IRepresentationModel implementation

		public override void UpdateNodes ()
		{
			/*	DeliveryPoint deliveryPointAlias = null;
			Counterparty counterpartyAlias = null;
			DeliveryPointVMNode resultAlias = null;

			var deliveryPointslist = UoW.Session.QueryOver<DeliveryPoint> (() => deliveryPointAlias)
				.JoinAlias (c => c.Counterparty, () => counterpartyAlias)
				.Where (() => counterpartyAlias.Id == CounterpartyUoW.Root.Id)
				.SelectList (list => list
					.Select (() => deliveryPointAlias.Id).WithAlias (() => resultAlias.Id)
					.Select (() => deliveryPointAlias.Building).WithAlias (() => resultAlias.Building)
					.Select (() => deliveryPointAlias.City).WithAlias (() => resultAlias.City)
					.Select (() => deliveryPointAlias.IsActive).WithAlias (() => resultAlias.IsActive)
					.Select (() => deliveryPointAlias.Name).WithAlias (() => resultAlias.Name)
					.Select (() => deliveryPointAlias.Street).WithAlias (() => resultAlias.Street)
					.Select (() => deliveryPointAlias.Room).WithAlias (() => resultAlias.Room)
			                         )
				.TransformUsing (Transformers.AliasToBean<DeliveryPointVMNode> ())
				.List<DeliveryPointVMNode> ();

			SetItemsSource (deliveryPointslist);*/
		}

		IMappingConfig treeViewConfig = FluentMappingConfig<AccountsVMNode>.Create ()
			.AddColumn ("Название").SetDataProperty (node => node.Point)
			.RowCells ().AddSetter<CellRendererText> ((c, n) => c.Foreground = n.RowColor)
			.Finish ();

		public override IMappingConfig TreeViewConfig {
			get { return treeViewConfig; }
		}

		#endregion

		#region implemented abstract members of RepresentationModelBase

		protected override bool NeedUpdateFunc (IAccountOwner updatedSubject)
		{
			return CounterpartyUoW.Root.Id == updatedSubject.Counterparty.Id;
		}

		protected override bool NeedUpdateFunc (object updatedSubject)
		{
			throw new NotImplementedException ();
		}

		#endregion

		public AccountsVM (IUnitOfWorkGeneric<IAccountOwner> uow)
		{
			this.UoW = uow;
		}
	}

	public class AccountsVMNode
	{

		public int Id { get; set; }

		public string Name { get; set; }

		public string City { get; set; }

		public string Street { get; set; }

		public string Building { get; set; }

		public string Room { get; set; }

		public bool IsActive { get; set; }

		public string RowColor { get { return IsActive ? "black" : "grey"; } }

		public string Point { 
			get { return String.Format ("{0}г. {1}, ул. {2}, д.{3}, квартира/офис {4}", 
				(Name == String.Empty ? "" : "\"" + Name + "\": "), City, Street, Building, Room); } 
		}
	}
}

