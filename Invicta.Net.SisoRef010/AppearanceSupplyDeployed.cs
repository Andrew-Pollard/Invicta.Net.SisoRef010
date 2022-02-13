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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(399, "Appearance-Supply Deployed", 2)]
	public enum AppearanceSupplyDeployed : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("db81450d-8b1f-40ac-b3f3-6590e5bdfc6b", Description="Not Applicable")]
		NotApplicable = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("60fd868f-7e92-4146-985c-16a84b547dc7", Description="Stowed")]
		Stowed = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("989467c1-fad7-43bf-b98e-d2ebdb39af8d", Description="Deployed")]
		Deployed = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("fe91dc4a-249b-4d12-847c-2bd3580b6793", Description="Deployed and Active")]
		DeployedAndActive = 3,
	}
}