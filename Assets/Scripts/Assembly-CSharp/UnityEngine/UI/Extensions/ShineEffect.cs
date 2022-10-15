namespace UnityEngine.UI.Extensions
{
	public class ShineEffect : MaskableGraphic
	{
		[SerializeField]
		private float yoffset;

		[SerializeField]
		private float width;

		public float Yoffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float Width
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void Triangulate(VertexHelper vh)
		{
		}

		public ShineEffect()
			: base()
		{
		}
	}
}
