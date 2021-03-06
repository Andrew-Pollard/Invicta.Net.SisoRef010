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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(155, "Transmitter-Major Modulation", 16)]
	public enum TransmitterMajorModulation : ushort {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18a4a5d2-526a-11df-b5fd-080069138b88", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18a5b2ec-526a-11df-b812-080069138b88", Description="Amplitude")]
		Amplitude = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18a6c5ce-526a-11df-a5d8-080069138b88", Description="Amplitude and Angle")]
		AmplitudeAndAngle = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18a7d46e-526a-11df-a1de-080069138b88", Description="Angle")]
		Angle = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18a8deea-526a-11df-92e3-080069138b88", Description="Combination")]
		Combination = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18a9eff6-526a-11df-8a6a-080069138b88", Description="Pulse")]
		Pulse = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18aaff40-526a-11df-aca0-080069138b88", Description="Unmodulated")]
		Unmodulated = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18ac0944-526a-11df-b41f-080069138b88", Description="Carrier Phase Shift Modulation (CPSM)")]
		CarrierPhaseShiftModulationCPSM = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c4491f69-6446-4410-91b3-7af16ee7d4af", Description="SATCOM")]
		SATCOM = 8,
	}
}
