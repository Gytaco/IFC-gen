/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class BuildingStorey : SpatialStructureElement 
	{
		public Double Elevation {get;set;}

		public BuildingStorey(Double elevation,
				Boolean elevationSpecified,
				ElementCompositionEnum compositionType,
				Boolean compositionTypeSpecified,
				SpatialElementContainsElements containsElements,
				SpatialElementReferencesElements referencesElements,
				String longName,
				ObjectPlacement objectPlacement,
				ProductRepresentation representation,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(compositionType,
				containsElements,
				referencesElements,
				longName,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.Elevation = elevation;
		}
	}
}