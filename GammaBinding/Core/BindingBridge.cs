﻿using System;
using System.Linq;
using System.Reflection;

namespace Gamma.Binding.Core
{
	public class BindingBridge : IBindingBridge
	{
		public PropertyInfo SourcePropertyInfo { get; private set;}
		public PropertyInfo[] TargetPropertyChain { get; private set;}

		public IBindingSource MyBindingSource { get; private set;}

		public BridgeMode Mode { get; private set;}

		public string SourcePropertyName{
			get { return SourcePropertyInfo.Name;
			}
		}

		public string TargetPropertyName{
			get { return String.Join (".", TargetPropertyChain.Select (p => p.Name));
			}
		}

		public BindingBridge (IBindingSource source, PropertyInfo sourcePropery, PropertyInfo[] targetProperyChain)
		{
			MyBindingSource = source;
			SourcePropertyInfo = sourcePropery;
			TargetPropertyChain = targetProperyChain;
			bool fromSource = SourcePropertyInfo.CanRead && TargetPropertyChain.Last ().CanWrite;
			bool fromTarget = SourcePropertyInfo.CanWrite && TargetPropertyChain.Last ().CanRead 
				&& MyBindingSource.Controler.BackwardProperties.Contains (TargetPropertyName);
			if (fromSource && fromTarget)
				Mode = BridgeMode.TwoWay;
			else if (fromSource)
				Mode = BridgeMode.OnlyFromSource;
			else if (fromTarget)
				Mode = BridgeMode.BackwardFromTarget;
			else
				throw new ArgumentException ("Невозможно вычислить направление биндинга, необходимо что бы хотябы одно свойство имело возможность записи, а другое чтение.");
		}

		public void SourcePropertyUpdated (string propertyName, object source)
		{
			if(SourcePropertyName == propertyName)
				MyBindingSource.Controler.TargetSetValue (TargetPropertyChain, SourcePropertyInfo.GetValue (source, null));
		}

		public object GetValueFromSource (object sourceObject)
		{
			return SourcePropertyInfo.GetValue (sourceObject, null);
		}

		public bool SetValueToSource (object sourceObject, object value)
		{
			if(SourcePropertyInfo.GetValue (sourceObject, null) != value)
			{
				SourcePropertyInfo.SetValue (sourceObject, value, null);
				return true;
			}
			return false;
		}
	}
}

