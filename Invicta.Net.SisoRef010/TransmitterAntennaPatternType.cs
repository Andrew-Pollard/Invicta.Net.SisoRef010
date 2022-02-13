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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(167, "Transmitter-Antenna Pattern Type", 16)]
	public enum TransmitterAntennaPatternType : ushort {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18f5b42c-526a-11df-ba06-080069138b88", Description="Omni-directional")]
		OmniDirectional = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18f6c1a0-526a-11df-9502-080069138b88", Description="Beam")]
		Beam = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("18f7d018-526a-11df-8d52-080069138b88", Description="Spherical harmonic")]
		[System.ObsoleteAttribute()]
		SphericalHarmonic = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2e7b8ca2-56ff-492d-b6fe-a619652c7c11", Description="Transmitter Radiation Volume")]
		TransmitterRadiationVolume = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5f3a5900-cbaf-4ebf-bf71-fa7e4b4a040c", Description="Beam and Transmitter Radiation Volume")]
		BeamAndTransmitterRadiationVolume = 5,
	}
}