/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CShapeProfileDef : ParameterizedProfileDef 
	{
		public Double Depth {get;set;}

		public Double Width {get;set;}

		public Double WallThickness {get;set;}

		public Double Girth {get;set;}

		public Double InternalFilletRadius {get;set;}

		public CShapeProfileDef(Double depth,
				Boolean depthSpecified,
				Double width,
				Boolean widthSpecified,
				Double wallThickness,
				Boolean wallThicknessSpecified,
				Double girth,
				Boolean girthSpecified,
				Double internalFilletRadius,
				Boolean internalFilletRadiusSpecified,
				Axis2Placement2D position,
				ProfileDefHasProperties hasProperties,
				ProfileTypeEnum profileType,
				Boolean profileTypeSpecified,
				String profileName) : base(position,
				hasProperties,
				profileType,
				profileName)
		{
			this.Depth = depth;
			this.Width = width;
			this.WallThickness = wallThickness;
			this.Girth = girth;
			this.InternalFilletRadius = internalFilletRadius;
		}
	}
}