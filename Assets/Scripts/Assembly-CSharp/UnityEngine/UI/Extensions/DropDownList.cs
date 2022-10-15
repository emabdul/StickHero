using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Dropdown List")]
	public class DropDownList : MonoBehaviour
	{
		[Serializable]
		public class SelectionChangedEvent : UnityEvent<int>
		{
			public SelectionChangedEvent()
				: base()
			{
			}
		}

		public Color disabledTextColor;

		public List<DropDownListItem> Items;

		public bool OverrideHighlighted;

		private bool _isPanelActive;

		private bool _hasDrawnOnce;

		private DropDownListButton _mainButton;

		private RectTransform _rectTransform;

		private RectTransform _overlayRT;

		private RectTransform _scrollPanelRT;

		private RectTransform _scrollBarRT;

		private RectTransform _slidingAreaRT;

		private RectTransform _itemsPanelRT;

		private Canvas _canvas;

		private RectTransform _canvasRT;

		private ScrollRect _scrollRect;

		private List<DropDownListButton> _panelItems;

		private GameObject _itemTemplate;

		[SerializeField]
		private float _scrollBarWidth;

		private int _selectedIndex;

		[SerializeField]
		private int _itemsToDisplay;

		public bool SelectFirstItemOnStart;

		public SelectionChangedEvent OnSelectionChanged;

		public DropDownListItem SelectedItem { get; private set; }

		public float ScrollBarWidth
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int ItemsToDisplay
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public void Start()
		{
		}

		private bool Initialize()
		{
			return default(bool);
		}

		private void RebuildPanel()
		{
		}

		private void OnItemClicked(int indx)
		{
		}

		private void UpdateSelected()
		{
		}

		private void RedrawPanel()
		{
		}

		public void ToggleDropdownPanel(bool directClick)
		{
		}

		public DropDownList()
			: base()
		{
		}
	}
}
