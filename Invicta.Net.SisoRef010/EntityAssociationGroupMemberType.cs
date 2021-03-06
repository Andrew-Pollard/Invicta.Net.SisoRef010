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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(321, "Entity Association-Group Member Type", 8)]
	public enum EntityAssociationGroupMemberType : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c3fc1a40-0270-4e80-9e4d-516a8f156ffa", Description="Not Part of a Group")]
		NotPartOfAGroup = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("b6ae72eb-15b1-427f-9a1a-959fd1c3818d", Description="Group Leader")]
		GroupLeader = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("233df253-00d5-4071-b660-adf16f97d5d3", Description="Group Member")]
		GroupMember = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e5536c16-e515-4af0-9166-c0e9bd304d8c", Description="Formation Leader")]
		FormationLeader = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5c37d45a-a526-4fca-8540-f5eed758ec61", Description="Formation Member")]
		FormationMember = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5b29bedc-910e-4d1d-b8ae-dda84955a731", Description="Convoy Leader")]
		ConvoyLeader = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0458bc1c-4118-4954-8563-1af06482ce5b", Description="Convoy Member")]
		ConvoyMember = 6,
	}
}
