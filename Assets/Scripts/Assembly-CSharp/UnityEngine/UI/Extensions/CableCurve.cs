using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[Serializable]
	public class CableCurve
	{
		[SerializeField]
		private Vector2 m_start;

		[SerializeField]
		private Vector2 m_end;

		[SerializeField]
		private float m_slack;

		[SerializeField]
		private int m_steps;

		[SerializeField]
		private bool m_regen;

		private static Vector2[] emptyCurve;

		[SerializeField]
		private Vector2[] points;

		public bool regenPoints
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Vector2 start
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 end
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float slack
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public int steps
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Vector2 midPoint
		{
			get
			{
				return default(Vector2);
			}
		}

		public CableCurve()
			: base()
		{
		}

		public CableCurve(Vector2[] inputPoints)
			: this()
		{
		}

		public CableCurve(List<Vector2> inputPoints)
			: this()
		{
		}

		public CableCurve(CableCurve v)
			: this()
		{
		}

		public Vector2[] Points()
		{
			return null;
		}
	}
}
