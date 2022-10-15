namespace UnityEngine.UI.Extensions.ColorPicker
{
	public struct HsvColor
	{
		public double H;

		public double S;

		public double V;

		public float NormalizedH
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalizedS
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalizedV
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public HsvColor(double h, double s, double v)
		{
			this.V = default(double);
			this.S = default(double);
			this.H = default(double);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
