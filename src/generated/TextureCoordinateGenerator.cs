/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class TextureCoordinateGenerator : TextureCoordinate 
	{
		public String Mode {get;set;}

		public Double[] Parameter {get;set;}

		public TextureCoordinateGenerator(String mode,
				Double[] parameter,
				TextureCoordinateMaps maps) : base(maps)
		{
			this.Mode = mode;
			this.Parameter = parameter;
		}
	}
}