/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class MaterialProfileSet : MaterialDefinition 
	{
		public MaterialProfileSetMaterialProfiles MaterialProfiles {get;set;}

		public CompositeProfileDef CompositeProfile {get;set;}

		public String Name {get;set;}

		public String Description {get;set;}

		public MaterialProfileSet(MaterialProfileSetMaterialProfiles materialProfiles,
				CompositeProfileDef compositeProfile,
				String name,
				String description,
				MaterialDefinitionHasProperties hasProperties) : base(hasProperties)
		{
			this.MaterialProfiles = materialProfiles;
			this.CompositeProfile = compositeProfile;
			this.Name = name;
			this.Description = description;
		}
	}
}