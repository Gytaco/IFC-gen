/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ElementAssembly : Element 
	{
		public AssemblyPlaceEnum AssemblyPlace {get;set;}

		public ElementAssemblyTypeEnum PredefinedType {get;set;}

		public ElementAssembly(AssemblyPlaceEnum assemblyPlace,
				Boolean assemblyPlaceSpecified,
				ElementAssemblyTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
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
			this.AssemblyPlace = assemblyPlace;
			this.PredefinedType = predefinedType;
		}
	}
}