/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class Approval : Entity 
	{
		public ApprovalRequestingApproval RequestingApproval {get;set;}

		public ApprovalGivingApproval GivingApproval {get;set;}

		public String Identifier {get;set;}

		public String Name {get;set;}

		public String Description {get;set;}

		public String TimeOfApproval {get;set;}

		public String Status {get;set;}

		public String Level {get;set;}

		public String Qualifier {get;set;}

		public Approval(ApprovalRequestingApproval requestingApproval,
				ApprovalGivingApproval givingApproval,
				String identifier,
				String name,
				String description,
				String timeOfApproval,
				String status,
				String level,
				String qualifier) : base()
		{
			this.RequestingApproval = requestingApproval;
			this.GivingApproval = givingApproval;
			this.Identifier = identifier;
			this.Name = name;
			this.Description = description;
			this.TimeOfApproval = timeOfApproval;
			this.Status = status;
			this.Level = level;
			this.Qualifier = qualifier;
		}
	}
}