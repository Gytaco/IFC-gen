/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Grid : Product 
	{
		public GridUAxes UAxes {get;set;}

		public GridVAxes VAxes {get;set;}

		public GridWAxes WAxes {get;set;}

		public GridTypeEnum PredefinedType {get;set;}

		public Grid(GridUAxes uAxes,
				GridVAxes vAxes,
				GridWAxes wAxes,
				GridTypeEnum predefinedType,
				Boolean predefinedTypeSpecified,
				ObjectPlacement objectPlacement,
				ProductRepresentation representation,
				RelDefinesByObject isDeclaredBy,
				RelDefinesByType isTypedBy,
				ObjectIsDefinedBy isDefinedBy,
				String objectType,
				ObjectDefinitionIsNestedBy isNestedBy,
				ObjectDefinitionIsDecomposedBy isDecomposedBy) : base(objectPlacement,
				representation,
				isDeclaredBy,
				isTypedBy,
				isDefinedBy,
				objectType,
				isNestedBy,
				isDecomposedBy)
		{
			this.UAxes = uAxes;
			this.VAxes = vAxes;
			this.WAxes = wAxes;
			this.PredefinedType = predefinedType;
		}
	}
}