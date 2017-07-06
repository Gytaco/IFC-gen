/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CurveBoundedPlane : BoundedSurface 
	{
		public Plane BasisSurface {get;set;}

		public Curve OuterBoundary {get;set;}

		public CurveBoundedPlaneInnerBoundaries InnerBoundaries {get;set;}

		public CurveBoundedPlane(Plane basisSurface,
				Curve outerBoundary,
				CurveBoundedPlaneInnerBoundaries innerBoundaries,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.BasisSurface = basisSurface;
			this.OuterBoundary = outerBoundary;
			this.InnerBoundaries = innerBoundaries;
		}
	}
}