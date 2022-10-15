using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	public class FancyScrollRectContext : IFancyScrollRectContext
	{
		ScrollDirection IFancyScrollRectContext.ScrollDirection { get; set; }

		//[TupleElementNames(new string[] { })]
		//Func<ValueTuple<float, float>> IFancyScrollRectContext.CalculateScrollSize
		//{
		//	get; [param: TupleElementNames(new string[] { })]
		//	set;
		//}

		public FancyScrollRectContext()
			: base()
		{
		}
	}
}
