namespace UnityEngine.UI.Extensions
{
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Effects/Extensions/Flippable")]
	public class UIFlippable : BaseMeshEffect
	{
		[SerializeField]
		private bool m_Horizontal;

		[SerializeField]
		private bool m_Veritical;

		public bool horizontal
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool vertical
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper verts)
		{
		}

		public UIFlippable()
			: base()
		{
		}
	}
}
