using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	public class FancyGridViewContext : IFancyGridViewContext, IFancyScrollRectContext, IFancyCellGroupContext
	{
		ScrollDirection IFancyScrollRectContext.ScrollDirection { get; set; }

		//[TupleElementNames(new string[] { })]
		//Func<ValueTuple<float, float>> IFancyScrollRectContext.CalculateScrollSize
		//{
		//	get; [param: TupleElementNames(new string[] { })]
		//	set;
		//}

		GameObject IFancyCellGroupContext.CellTemplate { get; set; }

		Func<int> IFancyCellGroupContext.GetGroupCount { get; set; }

		Func<float> IFancyGridViewContext.GetStartAxisSpacing { get; set; }

		Func<float> IFancyGridViewContext.GetCellSize { get; set; }

		public FancyGridViewContext()
			: base()
		{
		}
	}
}
