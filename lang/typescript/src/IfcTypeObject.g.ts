
import {BaseIfc} from "./BaseIfc"
import {IfcGloballyUniqueId} from "./IfcGloballyUniqueId.g"
import {IfcOwnerHistory} from "./IfcOwnerHistory.g"
import {IfcLabel} from "./IfcLabel.g"
import {IfcText} from "./IfcText.g"
import {IfcRelAssigns} from "./IfcRelAssigns.g"
import {IfcRelNests} from "./IfcRelNests.g"
import {IfcRelDeclares} from "./IfcRelDeclares.g"
import {IfcRelAggregates} from "./IfcRelAggregates.g"
import {IfcRelAssociates} from "./IfcRelAssociates.g"
import {IfcIdentifier} from "./IfcIdentifier.g"
import {IfcPropertySetDefinition} from "./IfcPropertySetDefinition.g"
import {IfcRelDefinesByType} from "./IfcRelDefinesByType.g"
import {IfcObjectDefinition} from "./IfcObjectDefinition.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctypeobject.htm
 */
export class IfcTypeObject extends IfcObjectDefinition {
	ApplicableOccurrence : IfcIdentifier // optional
	HasPropertySets : Array<IfcPropertySetDefinition> // optional
	Types : Array<IfcRelDefinesByType> // inverse

    constructor(globalId : IfcGloballyUniqueId) {
        super(globalId)
		this.HasPropertySets = new Array<IfcPropertySetDefinition>()
		this.Types = new Array<IfcRelDefinesByType>()

    }
    getStepParameters() : string {
        var parameters = new Array<string>();
		parameters.push(BaseIfc.toStepValue(this.GlobalId))
		parameters.push(BaseIfc.toStepValue(this.OwnerHistory))
		parameters.push(BaseIfc.toStepValue(this.Name))
		parameters.push(BaseIfc.toStepValue(this.Description))
		parameters.push(BaseIfc.toStepValue(this.ApplicableOccurrence))
		parameters.push(BaseIfc.toStepValue(this.HasPropertySets))

        return parameters.join();
    }
}