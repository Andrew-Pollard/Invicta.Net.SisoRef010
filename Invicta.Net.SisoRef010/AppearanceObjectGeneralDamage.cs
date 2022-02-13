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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(405, "Appearance-Object General-Damage", 2)]
	public enum AppearanceObjectGeneralDamage : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1ca508ac-526a-11df-9466-080069138b88", Description="No Damage")]
		NoDamage = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1ca618dc-526a-11df-847c-080069138b88", Description="Damaged")]
		Damaged = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1ca72ad8-526a-11df-b41a-080069138b88", Description="Destroyed")]
		Destroyed = 2,
	}
}
