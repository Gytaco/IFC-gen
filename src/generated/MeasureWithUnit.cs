/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class MeasureWithUnit : Entity 
	{
		public MeasureWithUnitValueComponent ValueComponent {get;set;}

		public MeasureWithUnitUnitComponent UnitComponent {get;set;}

		public MeasureWithUnit(MeasureWithUnitValueComponent valueComponent,
				MeasureWithUnitUnitComponent unitComponent) : base()
		{
			this.ValueComponent = valueComponent;
			this.UnitComponent = unitComponent;
		}
	}
}