using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	[AddComponentMenu("UI/Extensions/Extensions Toggle", 31)]
	public class ExtensionsToggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement
	{
		public enum ToggleTransition
		{
			None = 0,
			Fade = 1
		}

		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
			public ToggleEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class ToggleEventObject : UnityEvent<ExtensionsToggle>
		{
			public ToggleEventObject()
				: base()
			{
			}
		}

		public string UniqueID;

		public ToggleTransition toggleTransition;

		public Graphic graphic;

		[SerializeField]
		private ExtensionsToggleGroup m_Group;

		[Tooltip("Use this event if you only need the bool state of the toggle that was changed")]
		public ToggleEvent onValueChanged;

		[Tooltip("Use this event if you need access to the toggle that was changed")]
		public ToggleEventObject onToggleChanged;

		[SerializeField]
		[FormerlySerializedAs("m_IsActive")]
		[Tooltip("Is the toggle currently on or off?")]
		private bool m_IsOn;

		public ExtensionsToggleGroup Group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsOn
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		protected ExtensionsToggle()
			: base()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private void SetToggleGroup(ExtensionsToggleGroup newGroup, bool setMemberValue)
		{
		}

		private void Set(bool value)
		{
		}

		private void Set(bool value, bool sendCallback)
		{
		}

		private void PlayEffect(bool instant)
		{
		}

		protected override void Start()
		{
		}

		private void InternalToggle()
		{
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		Transform ICanvasElement.transform
		{
			get
			{
				return null;
			}
		}
	}
}
