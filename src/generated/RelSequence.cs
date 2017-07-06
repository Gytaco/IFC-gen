/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class RelSequence : RelConnects 
	{
		public Process RelatingProcess {get;set;}

		public Process RelatedProcess {get;set;}

		public LagTime TimeLag {get;set;}

		public SequenceEnum SequenceType {get;set;}

		public String UserDefinedSequenceType {get;set;}

		public RelSequence(Process relatingProcess,
				Process relatedProcess,
				LagTime timeLag,
				SequenceEnum sequenceType,
				Boolean sequenceTypeSpecified,
				String userDefinedSequenceType) : base()
		{
			this.RelatingProcess = relatingProcess;
			this.RelatedProcess = relatedProcess;
			this.TimeLag = timeLag;
			this.SequenceType = sequenceType;
			this.UserDefinedSequenceType = userDefinedSequenceType;
		}
	}
}