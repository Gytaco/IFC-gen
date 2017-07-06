/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class DoorType : BuildingElementType 
	{
		public DoorTypeEnum PredefinedType {get;set;}

		public DoorTypeOperationEnum OperationType {get;set;}

		public Boolean ParameterTakesPrecedence {get;set;}

		public String UserDefinedOperationType {get;set;}

		public DoorType(DoorTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				DoorTypeOperationEnum operationType,
				Boolean operationTypeSpecified,
				Boolean parameterTakesPrecedence,
				Boolean parameterTakesPrecedenceSpecified,
				String userDefinedOperationType,
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
			this.OperationType = operationType;
			this.ParameterTakesPrecedence = parameterTakesPrecedence;
			this.UserDefinedOperationType = userDefinedOperationType;
		}
	}
}