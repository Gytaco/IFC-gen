/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ApprovalRelationship : ResourceLevelRelationship 
	{
		public Approval RelatingApproval {get;set;}

		public ApprovalRelationshipRelatedApprovals RelatedApprovals {get;set;}

		public ApprovalRelationship(Approval relatingApproval,
				ApprovalRelationshipRelatedApprovals relatedApprovals,
				String name,
				String description) : base(name,
				description)
		{
			this.RelatingApproval = relatingApproval;
			this.RelatedApprovals = relatedApprovals;
		}
	}
}