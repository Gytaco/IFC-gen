/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Property : PropertyAbstraction 
	{
		public String Name {get;set;}

		public String Description {get;set;}

		public Property(String name,
				String description) : base()
		{
			this.Name = name;
			this.Description = description;
		}
	}
}