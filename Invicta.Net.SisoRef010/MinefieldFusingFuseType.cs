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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(422, "Minefield Fusing-Fuse Type", 7)]
	public enum MinefieldFusingFuseType : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a925cb8-526a-11df-a476-080069138b88", Description="No Fuse")]
		NoFuse = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a936676-526a-11df-ae68-080069138b88", Description="Other")]
		Other = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a9476c4-526a-11df-9977-080069138b88", Description="Pressure")]
		Pressure = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a958910-526a-11df-9000-080069138b88", Description="Magnetic")]
		Magnetic = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a9691b6-526a-11df-821a-080069138b88", Description="Tilt Rod")]
		TiltRod = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a97a344-526a-11df-b01b-080069138b88", Description="Command")]
		Command = 5,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1a98bcb6-526a-11df-a585-080069138b88", Description="Trip Wire")]
		TripWire = 6,
	}
}
