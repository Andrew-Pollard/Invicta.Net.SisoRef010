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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(13, "Platform-Space Category", 8)]
	public enum PlatformSpaceCategory : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2f47a04-5269-11df-af35-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2f582d2-5269-11df-a458-080069138b88", Description="Manned Spacecraft")]
		MannedSpacecraft = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2f694ce-5269-11df-bf69-080069138b88", Description="Unmanned")]
		[System.ObsoleteAttribute()]
		Unmanned = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("c2f7a378-5269-11df-80f5-080069138b88", Description="Booster")]
		Booster = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("50f3847a-8915-46b8-ae8d-a6d4ff0b3aca", Description="Debris")]
		Debris = 10,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("dce58e1f-309a-41a6-9d69-4fb30773d7cc", Description="Satellite - Unknown/Unspecified Mission")]
		SatelliteUnknownOrUnspecifiedMission = 11,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2fceac78-bfa1-4966-b50c-9707ec57c2ca", Description="Satellite - Communication")]
		SatelliteCommunication = 12,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("2821372b-2a9d-486b-bc8f-3f27b7434647", Description="Satellite - Navigation")]
		SatelliteNavigation = 13,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("8b16b616-af1b-4ca8-8fd3-f74a40dc4576", Description="Satellite - Science/Experimental/Demonstration")]
		SatelliteScienceOrExperimentalOrDemonstration = 14,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ca424b7b-56f3-44bd-9124-e4c71960b58a", Description="Satellite - Inert (Target/Reflector/Calibration)")]
		SatelliteInertTargetOrReflectorOrCalibration = 15,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("865324de-db1f-4168-a208-f46870402b07", Description="Satellite - Earth Observation")]
		SatelliteEarthObservation = 16,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ff671c49-a821-4f50-ad5a-3d67789154ef", Description="Satellite - Space Surveillance")]
		SatelliteSpaceSurveillance = 17,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e3ed4743-c9c2-4b56-81b4-630010b3afa5", Description="Satellite - Astronomy")]
		SatelliteAstronomy = 18,
	}
}
