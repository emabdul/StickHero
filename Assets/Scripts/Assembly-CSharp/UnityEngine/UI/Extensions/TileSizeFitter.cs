using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[ExecuteInEditMode]
	[AddComponentMenu("Layout/Extensions/Tile Size Fitter")]
	public class TileSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		[SerializeField]
		private Vector2 m_Border;

		[SerializeField]
		private Vector2 m_TileSize;

		[NonSerialized]
		private RectTransform m_Rect;

		private DrivenRectTransformTracker m_Tracker;

		public Vector2 Border
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 TileSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		private RectTransform rectTransform
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateRect()
		{
		}

		private Vector2 GetParentSize()
		{
			return default(Vector2);
		}

		public virtual void SetLayoutHorizontal()
		{
		}

		public virtual void SetLayoutVertical()
		{
		}

		protected void SetDirty()
		{
		}

		public TileSizeFitter()
			: base()
		{
		}
	}
}
