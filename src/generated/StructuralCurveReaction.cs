/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class StructuralCurveReaction : StructuralReaction 
	{
		public StructuralCurveActivityTypeEnum PredefinedType {get;set;}

		public StructuralCurveReaction(StructuralCurveActivityTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				StructuralLoad appliedLoad,
				GlobalOrLocalEnum globalOrLocal,
				Boolean globalOrLocalSpecified,
				ObjectPlacement objectPlacement,
				ProductRepresentation representation,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(appliedLoad,
				globalOrLocal,
				objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.PredefinedType = predefinedType;
		}
	}
}