using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	[Singleton("Popup/WaitingCanvas", true)]
	public class WaitingCanvas : Singleton<WaitingCanvas>
	{
		[SerializeField]
		private Text text;

		private IDisposable timeOutDisposable;

		public bool isShow { get; set; }

		public override void Awake()
		{
		}

		public void Show(string txt, Action timeoutAction = default(Action), float timeout = 15f)
		{
		}

		public void Hide()
		{
		}

		public WaitingCanvas()
			: base()
		{
		}
	}
}
