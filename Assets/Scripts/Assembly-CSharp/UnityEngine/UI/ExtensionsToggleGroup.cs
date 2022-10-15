using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Extensions/Extensions Toggle Group")]
	public class ExtensionsToggleGroup : UIBehaviour
	{
		[Serializable]
		public class ToggleGroupEvent : UnityEvent<bool>
		{
			public ToggleGroupEvent()
				: base()
			{
			}
		}

		[SerializeField]
		private bool m_AllowSwitchOff;

		private List<ExtensionsToggle> m_Toggles;

		public ToggleGroupEvent onToggleGroupChanged;

		public ToggleGroupEvent onToggleGroupToggleChanged;

		public bool AllowSwitchOff
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ExtensionsToggle SelectedToggle { get; private set; }

		protected ExtensionsToggleGroup()
			: base()
		{
		}

		private void ValidateToggleIsInGroup(ExtensionsToggle toggle)
		{
		}

		public void NotifyToggleOn(ExtensionsToggle toggle)
		{
		}

		public void UnregisterToggle(ExtensionsToggle toggle)
		{
		}

		private void NotifyToggleChanged(bool isOn)
		{
		}

		public void RegisterToggle(ExtensionsToggle toggle)
		{
		}

		public bool AnyTogglesOn()
		{
			return default(bool);
		}

		public IEnumerable<ExtensionsToggle> ActiveToggles()
		{
			return null;
		}

		public void SetAllTogglesOff()
		{
		}

		public void HasTheGroupToggle(bool value)
		{
		}

		public void HasAToggleFlipped(bool value)
		{
		}
	}
}
