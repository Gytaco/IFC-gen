/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class AnnotationFillArea : GeometricRepresentationItem 
	{
		public Curve OuterBoundary {get;set;}

		public AnnotationFillAreaInnerBoundaries InnerBoundaries {get;set;}

		public AnnotationFillArea(Curve outerBoundary,
				AnnotationFillAreaInnerBoundaries innerBoundaries,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.OuterBoundary = outerBoundary;
			this.InnerBoundaries = innerBoundaries;
		}
	}
}