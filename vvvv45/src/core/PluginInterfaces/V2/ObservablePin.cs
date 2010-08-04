﻿using System;
using VVVV.PluginInterfaces.V1;

namespace VVVV.PluginInterfaces.V2
{
	public abstract class ObservablePin<T> : Pin<T>, IObservableSpread<T>
	{
		public event SpreadChangedEventHander<T> Changed;
		
		public abstract bool IsChanged
		{
			get;
		}
		
		protected virtual void OnChanged()
		{
			if (Changed != null) 
				Changed(this);
		}
	}
}