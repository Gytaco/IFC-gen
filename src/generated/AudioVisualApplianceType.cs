/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class AudioVisualApplianceType : FlowTerminalType 
	{
		public AudioVisualApplianceTypeEnum PredefinedType {get;set;}

		public AudioVisualApplianceType(AudioVisualApplianceTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				String elementType,
				TypeProductRepresentationMaps representationMaps,
				String tag,
				TypeObjectHasPropertySets hasPropertySets,
				String applicableOccurrence,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(elementType,
				representationMaps,
				tag,
				hasPropertySets,
				applicableOccurrence,
				isNestedBy,
				isDecomposedBy)
		{
			this.PredefinedType = predefinedType;
		}
	}
}