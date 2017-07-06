/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Window : BuildingElement 
	{
		public Double OverallHeight {get;set;}

		public Double OverallWidth {get;set;}

		public WindowTypeEnum PredefinedType {get;set;}

		public WindowTypePartitioningEnum PartitioningType {get;set;}

		public String UserDefinedPartitioningType {get;set;}

		public Window(Double overallHeight,
				Boolean overallHeightSpecified,
				Double overallWidth,
				Boolean overallWidthSpecified,
				WindowTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				WindowTypePartitioningEnum partitioningType,
				Boolean partitioningTypeSpecified,
				String userDefinedPartitioningType,
				RelProjectsElement hasProjections,
				RelVoidsElement hasOpenings,
				String tag,
				ObjectPlacement objectPlacement,
				ProductRepresentation representation,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(hasProjections,
				hasOpenings,
				tag,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.OverallHeight = overallHeight;
			this.OverallWidth = overallWidth;
			this.PredefinedType = predefinedType;
			this.PartitioningType = partitioningType;
			this.UserDefinedPartitioningType = userDefinedPartitioningType;
		}
	}
}