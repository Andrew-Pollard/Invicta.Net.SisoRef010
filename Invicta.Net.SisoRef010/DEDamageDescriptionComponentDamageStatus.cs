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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(315, "DE Damage Description-Component Damage Status", 8)]
	public enum DEDamageDescriptionComponentDamageStatus : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e029d93a-b281-4595-a062-0c7cd01301f5", Description="No Damage")]
		NoDamage = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("012129a8-6a10-483f-a2d4-d14a3b4eab0d", Description="Minor Damage")]
		MinorDamage = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("90f05297-1207-41b6-915f-0c3822768fd3", Description="Medium Damage")]
		MediumDamage = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b4406919-cb88-4c8b-9c4b-4b6c684fd971", Description="Major Damage")]
		MajorDamage = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("40c17d2d-664e-4aae-a73f-4f90ba983466", Description="Destroyed")]
		Destroyed = 4,
	}
}
