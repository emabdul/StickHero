namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("Layout/Extensions/Radial Layout")]
	public class RadialLayout : LayoutGroup
	{
		public float fDistance;

		public float MinAngle;

		public float MaxAngle;

		public float StartAngle;

		public bool OnlyLayoutVisible;

		protected override void OnEnable()
		{
		}

		public override void SetLayoutHorizontal()
		{
		}

		public override void SetLayoutVertical()
		{
		}

		public override void CalculateLayoutInputVertical()
		{
		}

		public override void CalculateLayoutInputHorizontal()
		{
		}

		private void CalculateRadial()
		{
		}

		public RadialLayout()
			: base()
		{
		}
	}
}
