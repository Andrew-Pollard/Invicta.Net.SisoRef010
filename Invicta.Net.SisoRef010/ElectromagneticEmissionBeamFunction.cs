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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(78, "Electromagnetic Emission-Beam Function", 8)]
	public enum ElectromagneticEmissionBeamFunction : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162107f6-526a-11df-b37d-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162210e2-526a-11df-84d2-080069138b88", Description="Search")]
		Search = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16231f5a-526a-11df-afbc-080069138b88", Description="Height Finding")]
		HeightFinding = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16242f30-526a-11df-b9c5-080069138b88", Description="Acquisition")]
		Acquisition = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16253cc2-526a-11df-ba43-080069138b88", Description="Tracking")]
		Tracking = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16264ca2-526a-11df-a218-080069138b88", Description="Acquisition and tracking")]
		AcquisitionAndTracking = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16275b6a-526a-11df-8832-080069138b88", Description="Command guidance")]
		CommandGuidance = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16286604-526a-11df-bd83-080069138b88", Description="Illumination")]
		Illumination = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("16297ecc-526a-11df-b883-080069138b88", Description="Ranging")]
		Ranging = 8,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162a92ee-526a-11df-a0ac-080069138b88", Description="Missile beacon")]
		MissileBeacon = 9,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162b9af4-526a-11df-96f6-080069138b88", Description="Missile Fusing")]
		MissileFusing = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162ca9c6-526a-11df-ae7e-080069138b88", Description="Active radar missile seeker")]
		ActiveRadarMissileSeeker = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162dbb18-526a-11df-816c-080069138b88", Description="Jamming")]
		Jamming = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162ec620-526a-11df-be6c-080069138b88", Description="IFF")]
		IFF = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("162fd2a4-526a-11df-9b67-080069138b88", Description="Navigation / Weather")]
		NavigationOrWeather = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1630e644-526a-11df-ae27-080069138b88", Description="Meteorological")]
		Meteorological = 15,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1631efd0-526a-11df-9b74-080069138b88", Description="Data transmission")]
		DataTransmission = 16,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1632ff74-526a-11df-80e6-080069138b88", Description="Navigational directional beacon")]
		NavigationalDirectionalBeacon = 17,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("779aa098-c736-4922-960f-6b36500e670d", Description="Time-Shared Search")]
		TimeSharedSearch = 20,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c8192e8d-5759-4ab6-a071-0cc78603749b", Description="Time-Shared Acquisition")]
		TimeSharedAcquisition = 21,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("4acd47c4-5654-4784-bb3c-8f0b1376331d", Description="Time-Shared Track")]
		TimeSharedTrack = 22,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("278613b8-ca5e-4213-a8b4-654e4cb0d150", Description="Time-Shared Command Guidance")]
		TimeSharedCommandGuidance = 23,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("73d4d85f-0eb8-42fd-bd3a-d84e54b915f2", Description="Time-Shared Illumination")]
		TimeSharedIllumination = 24,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("92a5811b-8750-4c11-be77-26e38662a2dd", Description="Time-Shared Jamming")]
		TimeSharedJamming = 25,
	}
}
