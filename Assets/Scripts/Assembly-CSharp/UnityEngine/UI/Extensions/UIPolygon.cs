namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/UI Polygon")]
	public class UIPolygon : UIPrimitiveBase
	{
		public bool fill;

		public float thickness;

		public int sides;

		public float rotation;

		public float[] VerticesDistances;

		private float size;

		public void DrawPolygon(int _sides)
		{
		}

		public void DrawPolygon(int _sides, float[] _VerticesDistances)
		{
		}

		public void DrawPolygon(int _sides, float[] _VerticesDistances, float _rotation)
		{
		}

		private void Update()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public UIPolygon()
			: base()
		{
		}
	}
}
