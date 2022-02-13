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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(299, "NET ID Record-Frequency Table", 2)]
	public enum NETIDRecordFrequencyTable : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("3228a197-76d0-4363-935a-439b5ad81d5e", Description="HQ I Operations")]
		HQIOperations = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("f4429da1-ef6b-4b4e-b5f4-2df6d2f09831", Description="All HQII, HQIIA FM - NATO/Europe Area Operations")]
		AllHQIIHQIIAFMNATOOrEuropeAreaOperations = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("d181a5f8-fc85-494c-9f32-15f06597f358", Description="All HQII, HQIIA FM - Non-NATO/Europe Operations")]
		AllHQIIHQIIAFMNonNATOOrEuropeOperations = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1254f728-e4f4-4d7d-99e5-00610fd99617", Description="HQIIA (SATURN)")]
		HQIIASATURN = 3,
	}
}
