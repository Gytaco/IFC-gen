/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class OffsetCurve2D : Curve 
	{
		public Curve BasisCurve {get;set;}

		public Double Distance {get;set;}

		public Logical SelfIntersect {get;set;}

		public OffsetCurve2D(Curve basisCurve,
				Double distance,
				Boolean distanceSpecified,
				Logical selfIntersect,
				Boolean selfIntersectSpecified,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.BasisCurve = basisCurve;
			this.Distance = distance;
			this.SelfIntersect = selfIntersect;
		}
	}
}