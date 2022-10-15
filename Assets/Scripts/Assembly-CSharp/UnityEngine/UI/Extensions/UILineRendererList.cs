using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Primitives/UILineRendererList")]
	public class UILineRendererList : UIPrimitiveBase
	{
		private enum SegmentType
		{
			Start = 0,
			Middle = 1,
			End = 2,
			Full = 3
		}

		public enum JoinType
		{
			Bevel = 0,
			Miter = 1
		}

		public enum BezierType
		{
			None = 0,
			Quick = 1,
			Basic = 2,
			Improved = 3,
			Catenary = 4
		}

		private const float MIN_MITER_JOIN = (float)Math.PI / 12f;

		private const float MIN_BEVEL_NICE_JOIN = (float)Math.PI / 6f;

		private static Vector2 UV_TOP_LEFT;

		private static Vector2 UV_BOTTOM_LEFT;

		private static Vector2 UV_TOP_CENTER_LEFT;

		private static Vector2 UV_TOP_CENTER_RIGHT;

		private static Vector2 UV_BOTTOM_CENTER_LEFT;

		private static Vector2 UV_BOTTOM_CENTER_RIGHT;

		private static Vector2 UV_TOP_RIGHT;

		private static Vector2 UV_BOTTOM_RIGHT;

		private static Vector2[] startUvs;

		private static Vector2[] middleUvs;

		private static Vector2[] endUvs;

		private static Vector2[] fullUvs;

		[SerializeField]
		[Tooltip("Points to draw lines between\n Can be improved using the Resolution Option")]
		internal List<Vector2> m_points;

		[SerializeField]
		[Tooltip("Thickness of the line")]
		internal float lineThickness;

		[SerializeField]
		[Tooltip("Use the relative bounds of the Rect Transform (0,0 -> 0,1) or screen space coordinates")]
		internal bool relativeSize;

		[SerializeField]
		[Tooltip("Do the points identify a single line or split pairs of lines")]
		internal bool lineList;

		[SerializeField]
		[Tooltip("Add end caps to each line\nMultiple caps when used with Line List")]
		internal bool lineCaps;

		[SerializeField]
		[Tooltip("Resolution of the Bezier curve, different to line Resolution")]
		internal int bezierSegmentsPerCurve;

		[Tooltip("The type of Join used between lines, Square/Mitre or Curved/Bevel")]
		public JoinType LineJoins;

		[Tooltip("Bezier method to apply to line, see docs for options\nCan't be used in conjunction with Resolution as Bezier already changes the resolution")]
		public BezierType BezierMode;

		[HideInInspector]
		public bool drivenExternally;

		public float LineThickness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool RelativeSize
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LineList
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LineCaps
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int BezierSegmentsPerCurve
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public List<Vector2> Points
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void AddPoint(Vector2 pointToAdd)
		{
		}

		public void RemovePoint(Vector2 pointToRemove)
		{
		}

		public void ClearPoints()
		{
		}

		private void PopulateMesh(VertexHelper vh, List<Vector2> pointsToDraw)
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, SegmentType type)
		{
			return null;
		}

		protected override void GeneratedUVs()
		{
		}

		protected override void ResolutionToNativeSize(float distance)
		{
		}

		public UILineRendererList()
			: base()
		{
		}
	}
}
