using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI.Extensions
{
	public interface IFancyScrollRectContext
	{
		ScrollDirection ScrollDirection { get; set; }

		//[TupleElementNames(new string[] { })]
		//Func<ValueTuple<float, float>> CalculateScrollSize
		//{
		//	get; [param: TupleElementNames(new string[] { })]
		//	set;
		//}
	}
}
