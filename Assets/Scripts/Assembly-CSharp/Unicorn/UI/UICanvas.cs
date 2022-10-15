using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unicorn.UI
{
	public class UICanvas : MonoBehaviour
	{
		public bool isDestroyWhenClosed;

		public bool isDisableWhenClosed;

		public bool isAutoSetSortingLayer;

		protected bool isShow;

		private RectTransform _rect;

		private Stack<Action> _actionOpen;

		private Stack<Action> _actionClose;

		protected Stack<Action> actionOpen
		{
			get
			{
				return null;
			}
		}

		protected Stack<Action> actionClose
		{
			get
			{
				return null;
			}
		}

		private RectTransform Rect
		{
			get
			{
				return null;
			}
		}

		public bool IsShow
		{
			get
			{
				return default(bool);
			}
		}

		protected virtual void Awake()
		{
		}

		public void SetActionClose(Action _action)
		{
		}

		public void SetActionOpen(Action _action)
		{
		}

		public virtual void Show(bool _isShown, bool isHideMain = true)
		{
		}

		public virtual void OnBackPressed()
		{
		}

		public UICanvas()
			: base()
		{
		}
	}
}
