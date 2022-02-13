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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(26, "Expendable-Surface Category", 8)]
	public enum ExpendableSurfaceCategory : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c426152c-5269-11df-826a-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c42722aa-5269-11df-81f1-080069138b88", Description="Flare")]
		Flare = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c42831e0-5269-11df-9b8f-080069138b88", Description="Active Emitter")]
		ActiveEmitter = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c429415c-5269-11df-a252-080069138b88", Description="Passive Decoy")]
		PassiveDecoy = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("bccea111-e748-43c8-9279-dd82be22ba66", Description="Smoke Generator")]
		SmokeGenerator = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("35ce2134-63d6-4024-adef-ce3211fe5879", Description="Combined Flare and Smoke Generator")]
		CombinedFlareAndSmokeGenerator = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("435df631-ad1b-4e19-9177-ee09298ded74", Description="SAR Buoy")]
		SARBuoy = 14,
	}
}