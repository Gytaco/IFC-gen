/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class StructuralLinearAction : StructuralCurveAction 
	{


		public StructuralLinearAction(ProjectedOrTrueLengthEnum projectedOrTrue,
				Boolean projectedOrTrueSpecified,
				StructuralCurveActivityTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				Boolean destabilizingLoad,
				Boolean destabilizingLoadSpecified,
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
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(projectedOrTrue,
				predefinedType,
				destabilizingLoad,
				appliedLoad,
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
;
		}
	}
}