/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Axis2Placement2D : Placement 
	{
		public Direction RefDirection {get;set;}

		public Axis2Placement2D(Direction refDirection,
				CartesianPoint location,
				StyledItem styledByItem) : base(location,
				styledByItem)
		{
			this.RefDirection = refDirection;
		}
	}
}