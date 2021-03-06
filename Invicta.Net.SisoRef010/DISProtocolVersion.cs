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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(3, "DIS-Protocol Version", 8)]
	public enum DISProtocolVersion : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1ed527a-5269-11df-8509-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1ee60a2-5269-11df-8b65-080069138b88", Description="DIS PDU version 1.0 (May 92)")]
		DISPDUVersion1_0May92 = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1ef7258-5269-11df-84cc-080069138b88", Description="IEEE 1278-1993")]
		IEEE12781993 = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1f08314-5269-11df-b3f9-080069138b88", Description="DIS Applications Version 2.0 - Third Draft (28 May 1993)")]
		DISApplicationsVersion2_0ThirdDraft28May1993 = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1f19394-5269-11df-b5e1-080069138b88", Description="DIS Application Protocols Version 2.0 - Fourth Draft (Revised) (16 March 1994)")]
		DISApplicationProtocolsVersion2_0FourthDraftRevised16March1994 = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1f2a5ea-5269-11df-b53c-080069138b88", Description="IEEE 1278.1-1995")]
		IEEE1278_11995 = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c1f3b732-5269-11df-b47c-080069138b88", Description="IEEE 1278.1A-1998")]
		IEEE1278_1A1998 = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f1c9e470-51eb-4e9d-88ab-9ab706e68116", Description="IEEE 1278.1-2012")]
		IEEE1278_12012 = 7,
	}
}
