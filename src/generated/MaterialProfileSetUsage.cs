/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class MaterialProfileSetUsage : MaterialUsageDefinition 
	{
		public MaterialProfileSet ForProfileSet {get;set;}

		public Int64 CardinalPoint {get;set;}

		public Double ReferenceExtent {get;set;}

		public MaterialProfileSetUsage(MaterialProfileSet forProfileSet,
				Int64 cardinalPoint,
				Boolean cardinalPointSpecified,
				Double referenceExtent,
				Boolean referenceExtentSpecified) : base()
		{
			this.ForProfileSet = forProfileSet;
			this.CardinalPoint = cardinalPoint;
			this.ReferenceExtent = referenceExtent;
		}
	}
}