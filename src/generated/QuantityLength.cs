/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class QuantityLength : PhysicalSimpleQuantity 
	{
		public Double LengthValue {get;set;}

		public String Formula {get;set;}

		public QuantityLength(Double lengthValue,
				Boolean lengthValueSpecified,
				String formula,
				NamedUnit unit,
				String name,
				String description) : base(unit,
				name,
				description)
		{
			this.LengthValue = lengthValue;
			this.Formula = formula;
		}
	}
}