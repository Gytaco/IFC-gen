/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Binarywrapper : Binary 
	{
		public String id {get;set;}

		public String path {get;set;}

		public String[] pos {get;set;}

		public Binarywrapper(String id,
				String path,
				String[] pos,
				String extraBits,
				Byte[] value) : base(extraBits,
				value)
		{
			this.id = id;
			this.path = path;
			this.pos = pos;
		}
	}
}