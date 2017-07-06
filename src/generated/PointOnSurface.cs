/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class PointOnSurface : Point 
	{
		public Surface BasisSurface {get;set;}

		public Double PointParameterU {get;set;}

		public Double PointParameterV {get;set;}

		public PointOnSurface(Surface basisSurface,
				Double pointParameterU,
				Boolean pointParameterUSpecified,
				Double pointParameterV,
				Boolean pointParameterVSpecified,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.BasisSurface = basisSurface;
			this.PointParameterU = pointParameterU;
			this.PointParameterV = pointParameterV;
		}
	}
}