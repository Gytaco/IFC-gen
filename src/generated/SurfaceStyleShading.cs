/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class SurfaceStyleShading : PresentationItem 
	{
		public ColourRgb SurfaceColour {get;set;}

		public Double Transparency {get;set;}

		public SurfaceStyleShading(ColourRgb surfaceColour,
				Double transparency,
				Boolean transparencySpecified) : base()
		{
			this.SurfaceColour = surfaceColour;
			this.Transparency = transparency;
		}
	}
}