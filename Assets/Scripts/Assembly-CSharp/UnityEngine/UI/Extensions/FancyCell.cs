using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	public abstract class FancyCell<TItemData, TContext> : MonoBehaviour where TContext : class, new()
	{
		public int Index { get; set; }

		public virtual bool IsVisible
		{
			get
			{
				return default(bool);
			}
		}

		protected TContext Context { get; private set; }

		public virtual void SetContext(TContext context)
		{
		}

		public virtual void Initialize()
		{
		}

		public virtual void SetVisible(bool visible)
		{
		}

		public abstract void UpdateContent(TItemData itemData);

		public abstract void UpdatePosition(float position);

		public FancyCell()
			: base()
		{
		}
	}
	public abstract class FancyCell<TItemData> : FancyCell<TItemData, NullContext>
	{
		public sealed override void SetContext(NullContext context)
		{
		}

		public FancyCell()
			: base()
		{
		}
	}
}
