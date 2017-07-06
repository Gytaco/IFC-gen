/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class SectionedSpine : GeometricRepresentationItem 
	{
		public CompositeCurve SpineCurve {get;set;}

		public SectionedSpineCrossSections CrossSections {get;set;}

		public SectionedSpineCrossSectionPositions CrossSectionPositions {get;set;}

		public SectionedSpine(CompositeCurve spineCurve,
				SectionedSpineCrossSections crossSections,
				SectionedSpineCrossSectionPositions crossSectionPositions,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.SpineCurve = spineCurve;
			this.CrossSections = crossSections;
			this.CrossSectionPositions = crossSectionPositions;
		}
	}
}