/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class MaterialRelationship : ResourceLevelRelationship 
	{
		public Material RelatingMaterial {get;set;}

		public MaterialRelationshipRelatedMaterials RelatedMaterials {get;set;}

		public String Expression {get;set;}

		public MaterialRelationship(Material relatingMaterial,
				MaterialRelationshipRelatedMaterials relatedMaterials,
				String expression,
				String name,
				String description) : base(name,
				description)
		{
			this.RelatingMaterial = relatingMaterial;
			this.RelatedMaterials = relatedMaterials;
			this.Expression = expression;
		}
	}
}