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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(358, "Capability Report", 8)]
	public enum CapabilityReport : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("492c8726-ee08-4791-b37f-a3798c7b3ade", Description="No Communications Capability (CA)")]
		NoCommunicationsCapabilityCA = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d4d9e30f-ecc2-48d2-965a-f674d63eaaa8", Description="Reserved")]
		Reserved = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a615684-0df8-41e2-8007-ace8d47710ff", Description="Reserved")]
		Reserved_1 = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("36c4f63e-1cf2-4031-b30c-663560838c53", Description="Reserved")]
		Reserved_2 = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a3bbf951-c231-4b50-8d68-eaed93e01870", Description="Signifies at Least Comm-A and Comm-B Capability and Ability to Set CA Code 7 and " +
			"on the Ground")]
		SignifiesAtLeastCommAAndCommBCapabilityAndAbilityToSetCACode7AndOnTheGround = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("291a3ec6-1dde-4a61-835c-1e6367e18d8b", Description="Signifies at Least Comm-A and Comm-B capability and Ability to Set CA Code 7 and " +
			"Airborne")]
		SignifiesAtLeastCommAAndCommBCapabilityAndAbilityToSetCACode7AndAirborne = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9aeefb41-4eea-47a6-b96b-d5da661dd8a8", Description="Signifies at Least Comm-A and Comm-B capability and Ability to Set CA Code 7 and " +
			"Either Airborne or on the Ground")]
		SignifiesAtLeastCommAAndCommBCapabilityAndAbilityToSetCACode7AndEitherAirborneOrOnTheGround = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e7d36eee-c628-46f8-bc77-cd0d7ce367d9", Description="Signifies the Downlink Request (DR) Field Is Not Equal To 0 and The Flight Status" +
			" (FS) Field Equals 2, 3, 4 or 5, and Either Airborne or on the Ground")]
		SignifiesTheDownlinkRequestDRFieldIsNotEqualTo0AndTheFlightStatusFSFieldEquals234Or5AndEitherAirborneOrOnTheGround = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0c5b9c1c-c45b-47fa-937e-51ac30cb801e", Description="No Statement")]
		NoStatement = 255,
	}
}
