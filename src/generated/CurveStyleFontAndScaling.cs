/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class CurveStyleFontAndScaling : PresentationItem 
	{
		public CurveStyleFontAndScalingCurveFont CurveFont {get;set;}

		public String Name {get;set;}

		public Double CurveFontScaling {get;set;}

		public CurveStyleFontAndScaling(CurveStyleFontAndScalingCurveFont curveFont,
				String name,
				Double curveFontScaling,
				Boolean curveFontScalingSpecified) : base()
		{
			this.CurveFont = curveFont;
			this.Name = name;
			this.CurveFontScaling = curveFontScaling;
		}
	}
}