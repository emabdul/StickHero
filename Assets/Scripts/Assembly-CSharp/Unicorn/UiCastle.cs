using System.Runtime.CompilerServices;
using TMPro;
using Unicorn.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class UiCastle : UICanvas
	{
		[SerializeField]
		private Button btnBack;

		[SerializeField]
		private Button btnNext;

		[SerializeField]
		private Button btnPrev;

		[SerializeField]
		private TextMeshProUGUI txtCastle;

		[SerializeField]
		private GameObject fxConfetti;

		public BrothelManager brothelManager { get; set; }

		private void Start()
		{
		}

		public void Init()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		public void PlayFxConfetti()
		{
		}

		private void OnClickBtnNext()
		{
		}

		private void OnClickBtnPrev()
		{
		}

		private void OnClickBtnBack()
		{
		}

		public UiCastle()
			: base()
		{
		}
	}
}
