/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class IndexedPolygonalFace : TessellatedItem 
	{
		public Int64[] CoordIndex {get;set;}

		public IndexedPolygonalFace(Int64[] coordIndex,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.CoordIndex = coordIndex;
		}
	}
}