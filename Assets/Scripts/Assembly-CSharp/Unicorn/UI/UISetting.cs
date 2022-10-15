using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class UISetting : UICanvas
	{
		[SerializeField]
		private Image imageMusic;

		[SerializeField]
		private Button btnMusic;

		[SerializeField]
		private TextMeshProUGUI txtMusic;

		[SerializeField]
		private Image imageSound;

		[SerializeField]
		private Button btnSound;

		[SerializeField]
		private TextMeshProUGUI txtSound;

		[SerializeField]
		private Image imageVibrate;

		[SerializeField]
		private Button btnVibrate;

		[SerializeField]
		private TextMeshProUGUI txtVibrate;

		[SerializeField]
		private Button btnBack;

		[SerializeField]
		private Color colorON;

		[SerializeField]
		private Color colorOff;

		protected override void Awake()
		{
		}

		private void RestoreSettings()
		{
		}

		private void ToggleMusic()
		{
		}

		private void ToggleSound()
		{
		}

		private void ToggleVibrate()
		{
		}

		private void OnClickBtnBack()
		{
		}

		private void Rate()
		{
		}

		private void RestorePurchase()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public UISetting()
			: base()
		{
		}
	}
}
