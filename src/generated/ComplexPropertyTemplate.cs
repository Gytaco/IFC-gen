/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// 
	/// </summary>
	public class ComplexPropertyTemplate : PropertyTemplate 
	{
		public ComplexPropertyTemplateHasPropertyTemplates HasPropertyTemplates {get;set;}

		public String UsageName {get;set;}

		public ComplexPropertyTemplateTypeEnum TemplateType {get;set;}

		public ComplexPropertyTemplate(ComplexPropertyTemplateHasPropertyTemplates hasPropertyTemplates,
				String usageName,
				ComplexPropertyTemplateTypeEnum templateType,
				Boolean templateTypeSpecified) : base()
		{
			this.HasPropertyTemplates = hasPropertyTemplates;
			this.UsageName = usageName;
			this.TemplateType = templateType;
		}
	}
}