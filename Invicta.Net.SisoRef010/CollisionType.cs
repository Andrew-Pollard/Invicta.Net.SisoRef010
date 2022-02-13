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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(189, "Collision Type", 8)]
	public enum CollisionType : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a5071e0-526a-11df-8e7b-080069138b88", Description="Inelastic")]
		Inelastic = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a517f5e-526a-11df-8e65-080069138b88", Description="Elastic")]
		Elastic = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("6d55ccd5-a861-4f80-bb61-c606d81f14eb", Description="Boom nozzle has cleared the receiver\'s refueling receptacle")]
		BoomNozzleHasClearedTheReceiversRefuelingReceptacle = 55,
	}
}
