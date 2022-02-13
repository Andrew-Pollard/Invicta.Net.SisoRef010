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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(739, "Link 11B Message Sub Type", 8)]
	public enum Link11BMessageSubType : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("996ed6b9-d719-4b55-b422-811b4f2590dc", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0713e159-9479-4194-b501-a621ff85e143", Description="Transmission Frame")]
		TransmissionFrame = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("7b526c6f-13b2-4ef5-a20e-6e52247bb4b4", Description="Standby Signal")]
		StandbySignal = 2,
	}
}