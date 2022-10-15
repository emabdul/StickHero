using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	public abstract class FancyScrollView<TItemData, TContext> : MonoBehaviour where TContext : class, new()
	{
		[SerializeField]
		protected float cellInterval;

		[SerializeField]
		protected float scrollOffset;

		[SerializeField]
		protected bool loop;

		[SerializeField]
		protected Transform cellContainer;

		private readonly IList<FancyCell<TItemData, TContext>> pool;

		protected bool initialized;

		protected float currentPosition;

		protected abstract GameObject CellPrefab { get; }

		protected IList<TItemData> ItemsSource { get; set; }

		protected TContext Context { get; }

		protected virtual void Initialize()
		{
		}

		protected virtual void UpdateContents(IList<TItemData> itemsSource)
		{
		}

		protected virtual void Relayout()
		{
		}

		protected virtual void Refresh()
		{
		}

		protected virtual void UpdatePosition(float position)
		{
		}

		private void UpdatePosition(float position, bool forceRefresh)
		{
		}

		private void ResizePool(float firstPosition)
		{
		}

		private void UpdateCells(float firstPosition, int firstIndex, bool forceRefresh)
		{
		}

		private int CircularIndex(int i, int size)
		{
			return default(int);
		}

		public FancyScrollView()
			: base()
		{
		}
	}
	public abstract class FancyScrollView<TItemData> : FancyScrollView<TItemData, NullContext>
	{
		public FancyScrollView()
			: base()
		{
		}
	}
}
