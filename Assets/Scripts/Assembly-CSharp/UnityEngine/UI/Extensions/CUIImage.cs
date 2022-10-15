using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Effects/Extensions/Curly UI Image")]
	public class CUIImage : CUIGraphic
	{
		public static int SlicedImageCornerRefVertexIdx;

		public static int FilledImageCornerRefVertexIdx;

		[HideInInspector]
		[SerializeField]
		[Tooltip("For changing the size of the corner for tiled or sliced Image")]
		public Vector2 cornerPosRatio;

		[SerializeField]
		[HideInInspector]
		protected Vector2 oriCornerPosRatio;

		public Vector2 OriCornerPosRatio
		{
			get
			{
				return default(Vector2);
			}
		}

		public Image UIImage
		{
			get
			{
				return null;
			}
		}

		public static int ImageTypeCornerRefVertexIdx(Image.Type _type)
		{
			return default(int);
		}

		public override void ReportSet()
		{
		}

		protected override void modifyVertices(List<UIVertex> _verts)
		{
		}

		public CUIImage()
			: base()
		{
		}
	}
}
