using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Pagination Manager")]
	public class PaginationManager : ToggleGroup
	{
		private List<Toggle> m_PaginationChildren;

		[SerializeField]
		private ScrollSnapBase scrollSnap;

		private bool isAClick;

		public int CurrentPage
		{
			get
			{
				return default(int);
			}
		}

		protected PaginationManager()
			: base()
		{
		}

		protected override void Start()
		{
		}

		public void GoToScreen(int pageNo)
		{
		}

		private void ToggleClick(Toggle target)
		{
		}

		private void ToggleClick(bool toggle)
		{
		}

		private void ToggleClick(int target)
		{
		}

		private void SetToggleGraphics(int pageNo)
		{
		}

		private void OnPageChangeEnd(int pageNo)
		{
		}
	}
}
