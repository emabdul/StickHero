using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Effects/Extensions/Curly UI Graphic")]
	public class CUIGraphic : BaseMeshEffect
	{
		public static readonly int bottomCurveIdx;

		public static readonly int topCurveIdx;

		[SerializeField]
		[Tooltip("Set true to make the curve/morph to work. Set false to quickly see the original UI.")]
		protected bool isCurved;

		[SerializeField]
		[Tooltip("Set true to dynamically change the curve according to the dynamic change of the UI layout")]
		protected bool isLockWithRatio;

		[SerializeField]
		[Tooltip("Pick a higher resolution to improve the quality of the curved graphic.")]
		protected float resolution;

		protected RectTransform rectTrans;

		[SerializeField]
		[Tooltip("Put in the Graphic you want to curve/morph here.")]
		protected Graphic uiGraphic;

		[SerializeField]
		[Tooltip("Put in the reference Graphic that will be used to tune the bezier curves. Think button image and text.")]
		protected CUIGraphic refCUIGraphic;

		[SerializeField]
		[Tooltip("Do not touch this unless you are sure what you are doing. The curves are (re)generated automatically.")]
		protected CUIBezierCurve[] refCurves;

		[SerializeField]
		[HideInInspector]
		protected Vector3_Array2D[] refCurvesControlRatioPoints;

		protected List<UIVertex> reuse_quads;

		public bool IsCurved
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsLockWithRatio
		{
			get
			{
				return default(bool);
			}
		}

		public RectTransform RectTrans
		{
			get
			{
				return null;
			}
		}

		public Graphic UIGraphic
		{
			get
			{
				return null;
			}
		}

		public CUIGraphic RefCUIGraphic
		{
			get
			{
				return null;
			}
		}

		public CUIBezierCurve[] RefCurves
		{
			get
			{
				return null;
			}
		}

		public Vector3_Array2D[] RefCurvesControlRatioPoints
		{
			get
			{
				return null;
			}
		}

		protected void solveDoubleEquationWithVector(float _x_1, float _y_1, float _x_2, float _y_2, Vector3 _constant_1, Vector3 _contant_2, out Vector3 _x, out Vector3 _y)
		{
			_y = default(Vector3);
			_x = default(Vector3);
		}

		protected UIVertex uiVertexLerp(UIVertex _a, UIVertex _b, float _time)
		{
			return default(UIVertex);
		}

		protected UIVertex uiVertexBerp(UIVertex v_bottomLeft, UIVertex v_topLeft, UIVertex v_topRight, UIVertex v_bottomRight, float _xTime, float _yTime)
		{
			return default(UIVertex);
		}

		protected void tessellateQuad(List<UIVertex> _quads, int _thisQuadIdx)
		{
		}

		protected void tessellateGraphic(List<UIVertex> _verts)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public void Refresh()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		public virtual void ReportSet()
		{
		}

		public void FixTextToRectTrans()
		{
		}

		public void ReferenceCUIForBCurves()
		{
		}

		public override void ModifyMesh(Mesh _mesh)
		{
		}

		public override void ModifyMesh(VertexHelper _vh)
		{
		}

		protected virtual void modifyVertices(List<UIVertex> _verts)
		{
		}

		public void UpdateCurveControlPointPositions()
		{
		}

		public Vector3 GetBCurveSandwichSpacePoint(float _xTime, float _yTime)
		{
			return default(Vector3);
		}

		public Vector3 GetBCurveSandwichSpaceTangent(float _xTime, float _yTime)
		{
			return default(Vector3);
		}

		public CUIGraphic()
			: base()
		{
		}
	}
}
