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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(376, "Component Visual Damage Status-Surface Damage", 2)]
	public enum ComponentVisualDamageStatusSurfaceDamage : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ae40cdfa-22c8-4aaa-b935-b672bdc988f3", Description="Normal Appearance")]
		NormalAppearance = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3c31d41c-969f-4945-9ebe-aeda5675f38b", Description="Light Charring")]
		LightCharring = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ea2a18e9-49c4-4f91-8ce2-959777916df5", Description="Heavy Charring")]
		HeavyCharring = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6d24004a-a314-4fca-a960-555c6c7e594f", Description="One or More Holes Burned Completely through Surface")]
		OneOrMoreHolesBurnedCompletelyThroughSurface = 3,
	}
}
