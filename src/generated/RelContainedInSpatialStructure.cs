/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class RelContainedInSpatialStructure : RelConnects 
	{
		public RelContainedInSpatialStructureRelatedElements RelatedElements {get;set;}

		public RelContainedInSpatialStructure(RelContainedInSpatialStructureRelatedElements relatedElements) : base()
		{
			this.RelatedElements = relatedElements;
		}
	}
}