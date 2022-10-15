namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Effects/Extensions/Gradient")]
	public class Gradient : BaseMeshEffect
	{
		[SerializeField]
		private GradientMode _gradientMode;

		[SerializeField]
		private GradientDir _gradientDir;

		[SerializeField]
		private bool _overwriteAllColor;

		[SerializeField]
		private Color _vertex1;

		[SerializeField]
		private Color _vertex2;

		private Graphic targetGraphic;

		public GradientMode GradientMode
		{
			get
			{
				return default(GradientMode);
			}
			set
			{
			}
		}

		public GradientDir GradientDir
		{
			get
			{
				return default(GradientDir);
			}
			set
			{
			}
		}

		public bool OverwriteAllColor
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Color Vertex1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color Vertex2
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private bool CompareCarefully(Color col1, Color col2)
		{
			return default(bool);
		}

		public Gradient()
			: base()
		{
		}
	}
}
