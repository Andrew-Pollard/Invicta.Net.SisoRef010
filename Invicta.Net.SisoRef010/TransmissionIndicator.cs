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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(372, "Transmission Indicator", 8)]
	public enum TransmissionIndicator : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("04cbaa7a-5023-4287-ad02-4ac9a5adb4a5", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a2dd1eed-8676-46e7-aa63-0f23839554ec", Description="Original Interrogation")]
		OriginalInterrogation = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("537daf4e-2809-4353-817f-fb1b317f3b03", Description="Interrogation Reply")]
		InterrogationReply = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d2ea3d73-d4c0-4b59-bc19-248e48ccc52a", Description="Squitter Transmission")]
		SquitterTransmission = 3,
	}
}
