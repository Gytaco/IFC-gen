/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ReparametrisedCompositeCurveSegment : CompositeCurveSegment 
	{
		public Double ParamLength {get;set;}

		public ReparametrisedCompositeCurveSegment(Double paramLength,
				Boolean paramLengthSpecified,
				Curve parentCurve,
				TransitionCode transition,
				Boolean transitionSpecified,
				Boolean sameSense,
				Boolean sameSenseSpecified,
				StyledItem styledByItem) : base(parentCurve,
				transition,
				sameSense,
				styledByItem)
		{
			this.ParamLength = paramLength;
		}
	}
}