/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class SpecificHeatCapacityMeasurewrapper : Object 
	{
		public String id {get;set;}

		public String path {get;set;}

		public String[] pos {get;set;}

		public Double Value {get;set;}

		public SpecificHeatCapacityMeasurewrapper(String id,
				String path,
				String[] pos,
				Double value) : base()
		{
			this.id = id;
			this.path = path;
			this.pos = pos;
			this.Value = value;
		}
	}
}