/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ifcXML : uos 
	{
		public Entity[] Items {get;set;}

		public ifcXML(Entity[] items,
				uosHeader header,
				String id,
				String[] express,
				String[] configuration) : base(header,
				id,
				express,
				configuration)
		{
			this.Items = items;
		}
	}
}