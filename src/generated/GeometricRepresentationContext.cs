/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class GeometricRepresentationContext : RepresentationContext 
	{
		public GeometricRepresentationContextWorldCoordinateSystem WorldCoordinateSystem {get;set;}

		public Direction TrueNorth {get;set;}

		public GeometricRepresentationContextHasSubContexts HasSubContexts {get;set;}

		public CoordinateOperation HasCoordinateOperation {get;set;}

		public Int64 CoordinateSpaceDimension {get;set;}

		public Double Precision {get;set;}

		public GeometricRepresentationContext(GeometricRepresentationContextWorldCoordinateSystem worldCoordinateSystem,
				Direction trueNorth,
				GeometricRepresentationContextHasSubContexts hasSubContexts,
				CoordinateOperation hasCoordinateOperation,
				Int64 coordinateSpaceDimension,
				Boolean coordinateSpaceDimensionSpecified,
				Double precision,
				Boolean precisionSpecified,
				String contextIdentifier,
				String contextType) : base(contextIdentifier,
				contextType)
		{
			this.WorldCoordinateSystem = worldCoordinateSystem;
			this.TrueNorth = trueNorth;
			this.HasSubContexts = hasSubContexts;
			this.HasCoordinateOperation = hasCoordinateOperation;
			this.CoordinateSpaceDimension = coordinateSpaceDimension;
			this.Precision = precision;
		}
	}
}