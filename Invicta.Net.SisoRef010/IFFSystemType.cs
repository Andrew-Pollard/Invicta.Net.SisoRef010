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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(82, "IFF-System Type", 16)]
	public enum IFFSystemType : ushort {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("163d5a78-526a-11df-a318-080069138b88", Description="Not Used (Invalid Value)")]
		NotUsedInvalidValue = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("163e6936-526a-11df-abd7-080069138b88", Description="Mark X/XII/ATCRBS Transponder")]
		MarkXOrXIIOrATCRBSTransponder = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("163f7d44-526a-11df-9b40-080069138b88", Description="Mark X/XII/ATCRBS Interrogator")]
		MarkXOrXIIOrATCRBSInterrogator = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16408e50-526a-11df-91a7-080069138b88", Description="Soviet Transponder")]
		SovietTransponder = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16419818-526a-11df-bed5-080069138b88", Description="Soviet Interrogator")]
		SovietInterrogator = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1642a992-526a-11df-88d6-080069138b88", Description="RRB Transponder")]
		RRBTransponder = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("de12a87f-c1b0-4564-b15c-1c1ccec72e3e", Description="Mark XIIA Interrogator")]
		MarkXIIAInterrogator = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("cff12ef4-79ce-40f8-a1e4-1b9e6530024c", Description="Mode 5 Interrogator")]
		Mode5Interrogator = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("40abd592-5584-4e7d-8075-8fd5a850a05f", Description="Mode S Interrogator")]
		ModeSInterrogator = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("281e5c57-9118-4895-9eb3-71d9225b7c73", Description="Mark XIIA Transponder")]
		MarkXIIATransponder = 9,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2f7bd128-6f6c-47e3-911f-0b353e339ec2", Description="Mode 5 Transponder")]
		Mode5Transponder = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8fb028ab-1ed9-4dd2-abba-30b7a9babebd", Description="Mode S Transponder")]
		ModeSTransponder = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e99c4c6f-7fd1-4973-91f8-b2b969b106c0", Description="Mark XIIA Combined Interrogator/Transponder (CIT)")]
		MarkXIIACombinedInterrogatorOrTransponderCIT = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a90272c8-725f-41f4-ba22-36ae8defc10f", Description="Mark XII Combined Interrogator/Transponder (CIT)")]
		MarkXIICombinedInterrogatorOrTransponderCIT = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("cdcfef87-481d-4e3e-a429-116baefbf72a", Description="TCAS/ACAS Transceiver")]
		TCASOrACASTransceiver = 14,
	}
}