/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class RelAssignsToGroup : RelAssigns 
	{
		public Group RelatingGroup {get;set;}

		public RelAssignsToGroup(Group relatingGroup,
				RelAssignsRelatedObjects relatedObjects,
				ObjectTypeEnum relatedObjectsType,
				Boolean relatedObjectsTypeSpecified) : base(relatedObjects,
				relatedObjectsType)
		{
			this.RelatingGroup = relatingGroup;
		}
	}
}