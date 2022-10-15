namespace UnityEngine.UI.Extensions
{
	public class Circle
	{
		[SerializeField]
		private float xAxis;

		[SerializeField]
		private float yAxis;

		[SerializeField]
		private int steps;

		public float X
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float Y
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int Steps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Circle(float radius)
			: base()
		{
		}

		public Circle(float radius, int steps)
			: base()
		{
		}

		public Circle(float xAxis, float yAxis)
			: base()
		{
		}

		public Circle(float xAxis, float yAxis, int steps)
			: base()
		{
		}

		public Vector2 Evaluate(float t)
		{
			return default(Vector2);
		}

		public void Evaluate(float t, out Vector2 eval)
		{
			eval = default(Vector2);
		}
	}
}
