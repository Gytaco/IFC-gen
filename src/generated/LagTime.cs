/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class LagTime : SchedulingTime 
	{
		public LagTimeLagValue LagValue {get;set;}

		public TaskDurationEnum DurationType {get;set;}

		public LagTime(LagTimeLagValue lagValue,
				TaskDurationEnum durationType,
				Boolean durationTypeSpecified,
				String name,
				DataOriginEnum dataOrigin,
				Boolean dataOriginSpecified,
				String userDefinedDataOrigin) : base(name,
				dataOrigin,
				userDefinedDataOrigin)
		{
			this.LagValue = lagValue;
			this.DurationType = durationType;
		}
	}
}