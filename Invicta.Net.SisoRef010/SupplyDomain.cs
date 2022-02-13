//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//Copyright © 2010-2011, 2013-2021 by the Simulation Interoperability Standards Organization, Inc.
//7901 4th St N, Suite 300-4043
//St. Petersburg, FL 33702
//All rights reserved.
//
//Schema and API: SISO hereby grants a general, royalty-free license to copy, distribute, display, and
//make derivative works from this material, for all purposes, provided that any use of the material
//contains the following attribution: “Reprinted with permission from SISO Inc.” Should
//a reader require additional information, contact the SISO Inc. Board of Directors.
//
//Documentation: SISO hereby grants a general, royalty-free license to copy, distribute,
//display, and make derivative works from this material, for noncommercial purposes, provided that
//any use of the material contains the following attribution: “Reprinted with permission from SISO Inc.” 
//The material may not be used for a commercial purpose without express written
//permission from the SISO Inc Board of Directors.
//
//SISO Inc. Board of Directors
//7901 4th St N, Suite 300-4043
//St. Petersburg, FL 33702
//
namespace Invicta.Net.SisoRef010 {
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(600, "Supply Domain", 8)]
	public enum SupplyDomain : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dc7a118b-0df0-4f61-9787-6cb62744a462", Description="Not Used")]
		[System.ObsoleteAttribute()]
		NotUsed = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("25f6e972-fde3-49fe-9f12-d43adc6d19d7", Description="Class 1 - Subsistence")]
		Class1Subsistence = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9f0a81b5-aa7d-45e7-a5bc-f449720cbe95", Description="Class 2 - Clothing, Individual Equipment, Tools, Admin. Supplies")]
		Class2ClothingIndividualEquipmentToolsAdminSupplies = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0ad994d8-6d30-417e-ab1e-c112f6dd9785", Description="Class 3 - Petroleum, Oils, Lubricants")]
		Class3PetroleumOilsLubricants = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e97fefc3-fd7e-41e9-9403-ad9f341568b2", Description="Class 4 - Construction Materials")]
		Class4ConstructionMaterials = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dc6f5ca9-300a-4f07-a515-70aab5a4738f", Description="Class 5 - Ammunition")]
		[System.ObsoleteAttribute("Not used, as it is described in Munitions.")]
		Class5Ammunition = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("755cbd33-c29f-442f-bfe0-64933f6f7bf3", Description="Class 6 - Personnel Demand Items")]
		Class6PersonnelDemandItems = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2580e729-18ae-4560-b142-ef9b1e2e793a", Description="Class 7 - Major Items")]
		Class7MajorItems = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d49b3810-3753-4be9-89d6-99af21df0e7a", Description="Class 8 - Medical Material")]
		Class8MedicalMaterial = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3a9bfc7f-1785-455b-8422-592e350cf8b6", Description="Class 9 - Repair Parts and Components")]
		Class9RepairPartsAndComponents = 9,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6a28036e-d08f-40f0-8d7b-901708d7ecc4", Description="Class 10 - Material to Support Non-Military Programs")]
		Class10MaterialToSupportNonMilitaryPrograms = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("530ee00b-e69c-459b-94a7-ae8e883fe187", Description="Class 11 - Supplies (Non Doctrinal)")]
		Class11SuppliesNonDoctrinal = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("39d64f69-95d0-4181-84eb-cba81ff46e17", Description="Class 12 - Sling Loads (Non Doctrinal)")]
		Class12SlingLoadsNonDoctrinal = 12,
	}
}