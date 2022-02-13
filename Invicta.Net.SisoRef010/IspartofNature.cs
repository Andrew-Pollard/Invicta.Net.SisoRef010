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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(210, "IsPartOf-Nature", 16)]
	public enum IspartofNature : ushort {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b4dd79a-526a-11df-998b-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b4ee720-526a-11df-a0b8-080069138b88", Description="Host-fireable munition")]
		HostFireableMunition = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b4ff566-526a-11df-9315-080069138b88", Description="Munition carried as cargo")]
		MunitionCarriedAsCargo = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b511054-526a-11df-9fd0-080069138b88", Description="Fuel carried as cargo")]
		FuelCarriedAsCargo = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b5222aa-526a-11df-87fe-080069138b88", Description="Gunmount attached to host")]
		GunmountAttachedToHost = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b53385c-526a-11df-96f0-080069138b88", Description="Computer generated forces carried as cargo")]
		ComputerGeneratedForcesCarriedAsCargo = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b5443d2-526a-11df-83f0-080069138b88", Description="Vehicle carried as cargo")]
		VehicleCarriedAsCargo = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b555538-526a-11df-bd2e-080069138b88", Description="Emitter mounted on host")]
		EmitterMountedOnHost = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b566af4-526a-11df-a7c4-080069138b88", Description="Mobile command and control entity carried aboard host")]
		MobileCommandAndControlEntityCarriedAboardHost = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b577944-526a-11df-9756-080069138b88", Description="Entity stationed at position with respect to host")]
		EntityStationedAtPositionWithRespectToHost = 9,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b588bfe-526a-11df-8565-080069138b88", Description="Team member in formation with")]
		TeamMemberInFormationWith = 10,
	}
}
