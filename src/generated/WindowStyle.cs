/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class WindowStyle : TypeProduct 
	{
		public WindowStyleConstructionEnum ConstructionType {get;set;}

		public WindowStyleOperationEnum OperationType {get;set;}

		public Boolean ParameterTakesPrecedence {get;set;}

		public Boolean Sizeable {get;set;}

		public WindowStyle(WindowStyleConstructionEnum constructionType,
				Boolean constructionTypeSpecified,
				WindowStyleOperationEnum operationType,
				Boolean operationTypeSpecified,
				Boolean parameterTakesPrecedence,
				Boolean parameterTakesPrecedenceSpecified,
				Boolean sizeable,
				Boolean sizeableSpecified,
				TypeProductRepresentationMaps representationMaps,
				String tag,
				TypeObjectHasPropertySets hasPropertySets,
				String applicableOccurrence,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(representationMaps,
				tag,
				hasPropertySets,
				applicableOccurrence,
				isNestedBy,
				isDecomposedBy)
		{
			this.ConstructionType = constructionType;
			this.OperationType = operationType;
			this.ParameterTakesPrecedence = parameterTakesPrecedence;
			this.Sizeable = sizeable;
		}
	}
}