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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(205, "Aggregate State-Formation", 32)]
	public enum AggregateStateFormation : uint {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b12c7c2-526a-11df-b1c8-080069138b88", Description="Other")]
		Other = 0u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b13ddec-526a-11df-a7ef-080069138b88", Description="Assembly")]
		Assembly = 1u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b14ec96-526a-11df-beb0-080069138b88", Description="Vee")]
		Vee = 2u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b15fc94-526a-11df-b0bb-080069138b88", Description="Wedge")]
		Wedge = 3u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b170a12-526a-11df-b79d-080069138b88", Description="Line")]
		Line = 4u,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1b181a4c-526a-11df-80a2-080069138b88", Description="Column")]
		Column = 5u,
	}
}
