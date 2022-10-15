using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Cooldown Button")]
	public class CooldownButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		[Serializable]
		public class CooldownButtonEvent : UnityEvent<PointerEventData.InputButton>
		{
			public CooldownButtonEvent()
				: base()
			{
			}
		}

		[SerializeField]
		private float cooldownTimeout;

		[SerializeField]
		private float cooldownSpeed;

		[SerializeField]
		[ReadOnly]
		private bool cooldownActive;

		[SerializeField]
		[ReadOnly]
		private bool cooldownInEffect;

		[SerializeField]
		[ReadOnly]
		private float cooldownTimeElapsed;

		[SerializeField]
		[ReadOnly]
		private float cooldownTimeRemaining;

		[SerializeField]
		[ReadOnly]
		private int cooldownPercentRemaining;

		[ReadOnly]
		[SerializeField]
		private int cooldownPercentComplete;

		private PointerEventData buttonSource;

		[Tooltip("Event that fires when a button is initially pressed down")]
		public CooldownButtonEvent OnCooldownStart;

		[Tooltip("Event that fires when a button is released")]
		public CooldownButtonEvent OnButtonClickDuringCooldown;

		[Tooltip("Event that continually fires while a button is held down")]
		public CooldownButtonEvent OnCoolDownFinish;

		public float CooldownTimeout
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CooldownSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool CooldownInEffect
		{
			get
			{
				return default(bool);
			}
		}

		public bool CooldownActive
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float CooldownTimeElapsed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CooldownTimeRemaining
		{
			get
			{
				return default(float);
			}
		}

		public int CooldownPercentRemaining
		{
			get
			{
				return default(int);
			}
		}

		public int CooldownPercentComplete
		{
			get
			{
				return default(int);
			}
		}

		private void Update()
		{
		}

		public void PauseCooldown()
		{
		}

		public void RestartCooldown()
		{
		}

		public void StartCooldown()
		{
		}

		public void StopCooldown()
		{
		}

		public void CancelCooldown()
		{
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		public CooldownButton()
			: base()
		{
		}
	}
}
