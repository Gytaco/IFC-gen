/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class HalfSpaceSolid : GeometricRepresentationItem 
	{
		public Surface BaseSurface {get;set;}

		public Boolean AgreementFlag {get;set;}

		public HalfSpaceSolid(Surface baseSurface,
				Boolean agreementFlag,
				Boolean agreementFlagSpecified,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.BaseSurface = baseSurface;
			this.AgreementFlag = agreementFlag;
		}
	}
}