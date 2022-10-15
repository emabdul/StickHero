using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Effects/Extensions/Gradient2")]
	public class Gradient2 : BaseMeshEffect
	{
		public enum Type
		{
			Horizontal = 0,
			Vertical = 1,
			Radial = 2,
			Diamond = 3
		}

		public enum Blend
		{
			Override = 0,
			Add = 1,
			Multiply = 2
		}

		[SerializeField]
		private Type _gradientType;

		[SerializeField]
		private Blend _blendMode;

		[SerializeField]
		[Tooltip("Add vertices to display complex gradients. Turn off if your shape is already very complex, like text.")]
		private bool _modifyVertices;

		[SerializeField]
		private float _offset;

		[SerializeField]
		private float _zoom;

		[SerializeField]
		private UnityEngine.Gradient _effectGradient;

		public Blend BlendMode
		{
			get
			{
				return default(Blend);
			}
			set
			{
			}
		}

		public UnityEngine.Gradient EffectGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type GradientType
		{
			get
			{
				return default(Type);
			}
			set
			{
			}
		}

		public bool ModifyVertices
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float Offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float Zoom
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public override void ModifyMesh(VertexHelper helper)
		{
		}

		private Rect GetBounds(List<UIVertex> vertices)
		{
			return default(Rect);
		}

		private void SplitTrianglesAtGradientStops(List<UIVertex> _vertexList, Rect bounds, float zoomOffset, VertexHelper helper)
		{
		}

		private float[] GetPositions(List<UIVertex> _vertexList, int index)
		{
			return null;
		}

		private List<float> FindStops(float zoomOffset, Rect bounds)
		{
			return null;
		}

		private UIVertex CreateSplitVertex(UIVertex vertex1, UIVertex vertex2, float stop)
		{
			return default(UIVertex);
		}

		private Color BlendColor(Color colorA, Color colorB)
		{
			return default(Color);
		}

		public Gradient2()
			: base()
		{
		}
	}
}
