/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class AdvancedBrepWithVoids : AdvancedBrep 
	{
		public AdvancedBrepWithVoidsVoids Voids {get;set;}

		public AdvancedBrepWithVoids(AdvancedBrepWithVoidsVoids voids,
				ClosedShell outer,
				StyledItem styledByItem) : base(outer,
				styledByItem)
		{
			this.Voids = voids;
		}
	}
}