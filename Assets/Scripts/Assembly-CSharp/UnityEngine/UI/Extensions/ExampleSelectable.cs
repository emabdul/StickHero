using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	public class ExampleSelectable : MonoBehaviour, IBoxSelectable
	{
		private bool _selected;

		private bool _preSelected;

		private SpriteRenderer spriteRenderer;

		private Image image;

		private Text text;

		public bool selected
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool preSelected
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		Transform IBoxSelectable.transform
		{
			get
			{
				return null;
			}
		}

		public ExampleSelectable()
			: base()
		{
		}
	}
}
