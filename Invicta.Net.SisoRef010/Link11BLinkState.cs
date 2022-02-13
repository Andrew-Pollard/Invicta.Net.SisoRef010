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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(737, "Link 11B Link State", 8)]
	public enum Link11BLinkState : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("24d300bb-fc0c-478a-a62a-c69c84c45187", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f1a6d02e-014f-4cc7-a1ee-d3bba8c6b6cd", Description="Inactive")]
		Inactive = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2860aaa4-b399-4910-95b2-a064d0f06bc6", Description="Ready")]
		Ready = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0a40348f-c9db-43c3-8bbd-5b54829afae1", Description="Active")]
		Active = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("21ac738b-5754-4cb4-af57-0f34b1ea2385", Description="Operational")]
		Operational = 4,
	}
}
