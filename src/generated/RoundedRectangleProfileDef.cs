/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class RoundedRectangleProfileDef : RectangleProfileDef 
	{
		public Double RoundingRadius {get;set;}

		public RoundedRectangleProfileDef(Double roundingRadius,
				Boolean roundingRadiusSpecified,
				Double xDim,
				Boolean xDimSpecified,
				Double yDim,
				Boolean yDimSpecified,
				Axis2Placement2D position,
				ProfileDefHasProperties hasProperties,
				ProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName) : base(xDim,
				yDim,
				position,
				hasProperties,
				profileType,
				profileName)
		{
			this.RoundingRadius = roundingRadius;
		}
	}
}