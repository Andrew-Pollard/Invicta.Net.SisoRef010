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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(45, "Entity Marking-Character Set", 8)]
	public enum EntityMarkingCharacterSet : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2564ca98-d7c6-4764-b99c-e3cf0078b587", Description="Unused")]
		Unused = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037bd4e6-526a-11df-bbe0-080069138b88", Description="ASCII")]
		ASCII = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037ce020-526a-11df-8059-080069138b88", Description="U.S. Army Marking")]
		USArmyMarking = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("037df23a-526a-11df-b76f-080069138b88", Description="Digit Chevron")]
		DigitChevron = 3,
	}
}
