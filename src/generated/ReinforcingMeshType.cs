/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ReinforcingMeshType : ReinforcingElementType 
	{
		public ReinforcingMeshTypeBendingParameters BendingParameters {get;set;}

		public ReinforcingMeshTypeEnum PredefinedType {get;set;}

		public Double MeshLength {get;set;}

		public Double MeshWidth {get;set;}

		public Double LongitudinalBarNominalDiameter {get;set;}

		public Double TransverseBarNominalDiameter {get;set;}

		public Double LongitudinalBarCrossSectionArea {get;set;}

		public Double TransverseBarCrossSectionArea {get;set;}

		public Double LongitudinalBarSpacing {get;set;}

		public Double TransverseBarSpacing {get;set;}

		public String BendingShapeCode {get;set;}

		public ReinforcingMeshType(ReinforcingMeshTypeBendingParameters bendingParameters,
				ReinforcingMeshTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				Double meshLength,
				Boolean meshLengthSpecified,
				Double meshWidth,
				Boolean meshWidthSpecified,
				Double longitudinalBarNominalDiameter,
				Boolean longitudinalBarNominalDiameterSpecified,
				Double transverseBarNominalDiameter,
				Boolean transverseBarNominalDiameterSpecified,
				Double longitudinalBarCrossSectionArea,
				Boolean longitudinalBarCrossSectionAreaSpecified,
				Double transverseBarCrossSectionArea,
				Boolean transverseBarCrossSectionAreaSpecified,
				Double longitudinalBarSpacing,
				Boolean longitudinalBarSpacingSpecified,
				Double transverseBarSpacing,
				Boolean transverseBarSpacingSpecified,
				String bendingShapeCode,
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
			this.BendingParameters = bendingParameters;
			this.PredefinedType = predefinedType;
			this.MeshLength = meshLength;
			this.MeshWidth = meshWidth;
			this.LongitudinalBarNominalDiameter = longitudinalBarNominalDiameter;
			this.TransverseBarNominalDiameter = transverseBarNominalDiameter;
			this.LongitudinalBarCrossSectionArea = longitudinalBarCrossSectionArea;
			this.TransverseBarCrossSectionArea = transverseBarCrossSectionArea;
			this.LongitudinalBarSpacing = longitudinalBarSpacing;
			this.TransverseBarSpacing = transverseBarSpacing;
			this.BendingShapeCode = bendingShapeCode;
		}
	}
}