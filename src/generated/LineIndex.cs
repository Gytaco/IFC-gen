/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class LineIndex : Object 
	{
		public String[] itemType {get;set;}

		public aggregateType[] cType {get;set;}

		public String[] arraySize {get;set;}

		public Int64[] Text {get;set;}

		public LineIndex(String[] itemType,
				aggregateType[] cType,
				String[] arraySize,
				Int64[] text) : base()
		{
			this.itemType = itemType;
			this.cType = cType;
			this.arraySize = arraySize;
			this.Text = text;
		}
	}
}