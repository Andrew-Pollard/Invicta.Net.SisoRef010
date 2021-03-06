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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(332, "Ownership Status", 8)]
	public enum OwnershipStatus : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9d2ba55f-0dda-4429-b400-79c864fb0da1", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f237079f-689a-4fae-aef6-a626f2274dfd", Description="New Owner")]
		NewOwner = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b4565a64-2cc4-4e6f-9e4c-04761fd1dac6", Description="Ownership Query Response")]
		OwnershipQueryResponse = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("06ac0997-2e82-4a21-bc6b-14578a1817a6", Description="Ownership Conflict")]
		OwnershipConflict = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6bbcf01a-3e8a-49eb-98b2-aa05d424f2fa", Description="Local Entity Cancelled - Auto Resolve Conflict")]
		LocalEntityCancelledAutoResolveConflict = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a63c7633-eea5-42af-8870-ce4418091f51", Description="Local Entity Cancelled - Manual Resolve Conflict")]
		LocalEntityCancelledManualResolveConflict = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f55b6e45-b804-4e6b-8323-5e51e1ce6c4d", Description="Local Entity Cancelled - Remove Entity TCR Received")]
		LocalEntityCancelledRemoveEntityTCRReceived = 6,
	}
}
