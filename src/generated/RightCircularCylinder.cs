/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class RightCircularCylinder : CsgPrimitive3D 
	{
		public Double Height {get;set;}

		public Double Radius {get;set;}

		public RightCircularCylinder(Double height,
				Boolean heightSpecified,
				Double radius,
				Boolean radiusSpecified,
				Axis2Placement3D position,
				StyledItem styledByItem) : base(position,
				styledByItem)
		{
			this.Height = height;
			this.Radius = radius;
		}
	}
}