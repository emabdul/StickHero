using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Input Field Submit")]
	public class InputFieldEnterSubmit : MonoBehaviour
	{
		[Serializable]
		public class EnterSubmitEvent : UnityEvent<string>
		{
			public EnterSubmitEvent()
				: base()
			{
			}
		}

		public EnterSubmitEvent EnterSubmit;

		public bool defocusInput;

		private InputField _input;

		private void Awake()
		{
		}

		public void OnEndEdit(string txt)
		{
		}

		public InputFieldEnterSubmit()
			: base()
		{
		}
	}
}
