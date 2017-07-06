/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ProjectedCRS : CoordinateReferenceSystem 
	{
		public NamedUnit MapUnit {get;set;}

		public String MapProjection {get;set;}

		public String MapZone {get;set;}

		public ProjectedCRS(NamedUnit mapUnit,
				String mapProjection,
				String mapZone,
				String name,
				String description,
				String geodeticDatum,
				String verticalDatum) : base(name,
				description,
				geodeticDatum,
				verticalDatum)
		{
			this.MapUnit = mapUnit;
			this.MapProjection = mapProjection;
			this.MapZone = mapZone;
		}
	}
}