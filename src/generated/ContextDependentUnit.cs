/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ContextDependentUnit : NamedUnit 
	{
		public String Name {get;set;}

		public ContextDependentUnit(String name,
				DimensionalExponents dimensions,
				UnitEnum unitType,
				Boolean unitTypeSpecified) : base(dimensions,
				unitType)
		{
			this.Name = name;
		}
	}
}