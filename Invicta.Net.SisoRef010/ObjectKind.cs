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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(225, "Object Kind", 8)]
	public enum ObjectKind : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c1d632a-526a-11df-b628-080069138b88", Description="Other")]
		Other = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c1e6bd0-526a-11df-9a39-080069138b88", Description="Obstacle")]
		Obstacle = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c1f81a0-526a-11df-800a-080069138b88", Description="Prepared Position")]
		PreparedPosition = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c209752-526a-11df-9da3-080069138b88", Description="Cultural Feature")]
		CulturalFeature = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c21af0c-526a-11df-8db4-080069138b88", Description="Passageway")]
		Passageway = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c22bf78-526a-11df-b87a-080069138b88", Description="Tactical Smoke")]
		TacticalSmoke = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c23d020-526a-11df-826f-080069138b88", Description="Obstacle Marker")]
		ObstacleMarker = 6,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1c24dc72-526a-11df-b017-080069138b88", Description="Obstacle Breach")]
		ObstacleBreach = 7,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9a2ef931-a986-414e-b197-c85151d8e24c", Description="Environmental Object")]
		EnvironmentalObject = 8,
	}
}
