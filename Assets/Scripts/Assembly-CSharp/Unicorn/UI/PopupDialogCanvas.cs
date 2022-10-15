using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	[Singleton("Popup/PopupDialogCanvas", true)]
	public class PopupDialogCanvas : Singleton<PopupDialogCanvas>
	{
		[SerializeField]
		private Text text;

		[SerializeField]
		private Button btnClose;

		public bool isShow { get; set; }

		public override void Awake()
		{
		}

		public void Show(string txt)
		{
		}

		public void Hide()
		{
		}

		public PopupDialogCanvas()
			: base()
		{
		}
	}
}
