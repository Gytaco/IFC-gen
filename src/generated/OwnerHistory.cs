/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class OwnerHistory : Entity 
	{
		public PersonAndOrganization OwningUser {get;set;}

		public Application OwningApplication {get;set;}

		public PersonAndOrganization LastModifyingUser {get;set;}

		public Application LastModifyingApplication {get;set;}

		public StateEnum State {get;set;}

		public ChangeActionEnum ChangeAction {get;set;}

		public Int64 LastModifiedDate {get;set;}

		public Int64 CreationDate {get;set;}

		public OwnerHistory(PersonAndOrganization owningUser,
				Application owningApplication,
				PersonAndOrganization lastModifyingUser,
				Application lastModifyingApplication,
				StateEnum state,
				Boolean stateSpecified,
				ChangeActionEnum changeAction,
				Boolean changeActionSpecified,
				Int64 lastModifiedDate,
				Boolean lastModifiedDateSpecified,
				Int64 creationDate,
				Boolean creationDateSpecified) : base()
		{
			this.OwningUser = owningUser;
			this.OwningApplication = owningApplication;
			this.LastModifyingUser = lastModifyingUser;
			this.LastModifyingApplication = lastModifyingApplication;
			this.State = state;
			this.ChangeAction = changeAction;
			this.LastModifiedDate = lastModifiedDate;
			this.CreationDate = creationDate;
		}
	}
}