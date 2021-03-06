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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(730, "Link 11 Message Sub Type", 8)]
	public enum Link11MessageSubType : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("679b713d-f10f-47fc-b26e-b00ae2c76402", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e9b89a2c-148b-4d77-8531-e187d8e0a1ff", Description="Interrogation")]
		Interrogation = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ccbf0d3c-71a4-4ec8-bcad-f359127cb7b3", Description="Intermediate Data")]
		IntermediateData = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("88019af5-19d7-48d5-a9fa-4fbc7009b623", Description="Final Data")]
		FinalData = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("01e75f71-d259-4263-9755-68556a896432", Description="Final Data and Interrogation")]
		FinalDataAndInterrogation = 4,
	}
}
