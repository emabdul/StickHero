using System;
using System.Runtime.InteropServices;

namespace UnityEngine.UI.Extensions
{
	[Serializable]
	public class DropDownListItem
	{
		[SerializeField]
		private string _caption;

		[SerializeField]
		private Sprite _image;

		[SerializeField]
		private bool _isDisabled;

		[SerializeField]
		private string _id;

		public Action OnSelect;

		internal Action OnUpdate;

		public string Caption
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Sprite Image
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsDisabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string ID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DropDownListItem(string caption = "", string inId = "", Sprite image = default(Sprite), bool disabled = false, Action onSelect = default(Action))
			: base()
		{
		}
	}
}
