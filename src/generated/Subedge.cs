/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Subedge : Edge 
	{
		public Edge ParentEdge {get;set;}

		public Subedge(Edge parentEdge,
				Vertex edgeStart,
				Vertex edgeEnd,
				StyledItem styledByItem) : base(edgeStart,
				edgeEnd,
				styledByItem)
		{
			this.ParentEdge = parentEdge;
		}
	}
}