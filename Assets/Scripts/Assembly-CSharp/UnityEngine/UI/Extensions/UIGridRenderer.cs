namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/UIGridRenderer")]
	public class UIGridRenderer : UILineRenderer
	{
		[SerializeField]
		private int m_GridColumns;

		[SerializeField]
		private int m_GridRows;

		public int GridColumns
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int GridRows
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public UIGridRenderer()
			: base()
		{
		}
	}
}
