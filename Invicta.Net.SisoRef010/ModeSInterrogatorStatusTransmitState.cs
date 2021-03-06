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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(347, "Mode S Interrogator Status Transmit State", 3)]
	public enum ModeSInterrogatorStatusTransmitState : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9f20744a-a835-47d5-aa3a-063a3eb9a0ea", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e37633af-20bb-4059-825a-c6ffbd748b4f", Description="Roll-Call")]
		RollCall = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("9a344dc7-5011-4b18-b133-bf63f2a074ca", Description="All Call")]
		AllCall = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5c98e6e5-5c8f-4447-97cc-db716f05610f", Description="Lockout Override")]
		LockoutOverride = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a6733b74-3638-43ef-afdd-ee2fb5ec76f3", Description="Temporary Lockout")]
		TemporaryLockout = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("571c2979-0fcc-48be-b3ce-19b5dfa1ac36", Description="Intermittent Lockout")]
		IntermittentLockout = 5,
	}
}
