/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class LightDistributionData : Entity 
	{
		public Double MainPlaneAngle {get;set;}

		public Double[] SecondaryPlaneAngle {get;set;}

		public Double[] LuminousIntensity {get;set;}

		public LightDistributionData(Double mainPlaneAngle,
				Boolean mainPlaneAngleSpecified,
				Double[] secondaryPlaneAngle,
				Double[] luminousIntensity) : base()
		{
			this.MainPlaneAngle = mainPlaneAngle;
			this.SecondaryPlaneAngle = secondaryPlaneAngle;
			this.LuminousIntensity = luminousIntensity;
		}
	}
}