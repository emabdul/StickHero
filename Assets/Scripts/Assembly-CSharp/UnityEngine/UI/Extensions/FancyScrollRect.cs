using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions
{
	public abstract class FancyScrollRect<TItemData, TContext> : FancyScrollView<TItemData, TContext> where TContext : class, IFancyScrollRectContext, new()
	{
		[SerializeField]
		protected float reuseCellMarginCount;

		[SerializeField]
		protected float paddingHead;

		[SerializeField]
		protected float paddingTail;

		[SerializeField]
		protected float spacing;

		private Scroller cachedScroller;

		protected abstract float CellSize { get; }

		protected virtual bool Scrollable
		{
			get
			{
				return default(bool);
			}
		}

		protected Scroller Scroller
		{
			get
			{
				return null;
			}
		}

		private float ScrollLength
		{
			get
			{
				return default(float);
			}
		}

		private float ViewportLength
		{
			get
			{
				return default(float);
			}
		}

		private float PaddingHeadLength
		{
			get
			{
				return default(float);
			}
		}

		private float MaxScrollPosition
		{
			get
			{
				return default(float);
			}
		}

		protected override void Initialize()
		{
		}

		private void OnScrollerValueChanged(float p)
		{
		}

		private void ShrinkScrollbar(float offset)
		{
		}

		protected override void Refresh()
		{
		}

		protected override void Relayout()
		{
		}

		protected void RefreshScroller()
		{
		}

		protected override void UpdateContents(IList<TItemData> items)
		{
		}

		protected new void UpdatePosition(float position)
		{
		}

		protected virtual void JumpTo(int itemIndex, float alignment = 0.5f)
		{
		}

		protected virtual void ScrollTo(int index, float duration, float alignment = 0.5f, Action onComplete = default(Action))
		{
		}

		protected virtual void ScrollTo(int index, float duration, Ease easing, float alignment = 0.5f, Action onComplete = default(Action))
		{
		}

		protected void UpdateScrollbarSize(float viewportLength)
		{
		}

		protected float ToFancyScrollViewPosition(float position)
		{
			return default(float);
		}

		protected float ToScrollerPosition(float position)
		{
			return default(float);
		}

		protected float ToScrollerPosition(float position, float alignment = 0.5f)
		{
			return default(float);
		}

		protected void AdjustCellIntervalAndScrollOffset()
		{
		}

		protected virtual void OnValidate()
		{
		}

		public FancyScrollRect()
			: base()
		{
		}
	}
	public abstract class FancyScrollRect<TItemData> : FancyScrollRect<TItemData, FancyScrollRectContext>
	{
		public FancyScrollRect()
			: base()
		{
		}
	}
}
