using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/ComboBox")]
	public class ComboBox : MonoBehaviour
	{
		[Serializable]
		public class SelectionChangedEvent : UnityEvent<string>
		{
			public SelectionChangedEvent()
				: base()
			{
			}
		}

		public Color disabledTextColor;

		public List<string> AvailableOptions;

		[SerializeField]
		private float _scrollBarWidth;

		[SerializeField]
		private int _itemsToDisplay;

		public SelectionChangedEvent OnSelectionChanged;

		private bool _isPanelActive;

		private bool _hasDrawnOnce;

		private InputField _mainInput;

		private RectTransform _inputRT;

		private RectTransform _rectTransform;

		private RectTransform _overlayRT;

		private RectTransform _scrollPanelRT;

		private RectTransform _scrollBarRT;

		private RectTransform _slidingAreaRT;

		private RectTransform _itemsPanelRT;

		private Canvas _canvas;

		private RectTransform _canvasRT;

		private ScrollRect _scrollRect;

		private List<string> _panelItems;

		private Dictionary<string, GameObject> panelObjects;

		private GameObject itemTemplate;

		public DropDownListItem SelectedItem { get; private set; }

		public string Text { get; private set; }

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

		public void Awake()
		{
		}

		private bool Initialize()
		{
			return default(bool);
		}

		private void RebuildPanel()
		{
		}

		private void OnItemClicked(string item)
		{
		}

		private void RedrawPanel()
		{
		}

		public void OnValueChanged(string currText)
		{
		}

		public void ToggleDropdownPanel(bool directClick)
		{
		}

		public ComboBox()
			: base()
		{
		}
	}
}
