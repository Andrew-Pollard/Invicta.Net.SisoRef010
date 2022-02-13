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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(470, "Link 11 Mode of Operation", 16)]
	public enum Link11ModeOfOperation : ushort {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("e79a526f-69b5-409a-a6de-3de876a9067e", Description="No Statement")]
		NoStatement = 0,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("1f6d5e98-d462-44e4-bd26-ebfc046d1158", Description="Net Sync")]
		NetSync = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5be8df65-fb5f-434f-a4f2-b7d5fe33a6e7", Description="Net Test")]
		NetTest = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5d7c1602-6265-4af1-96c9-fbc5e0cbc7f3", Description="Roll Call")]
		RollCall = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("93ec9228-9b9f-4224-af46-6a7149411e4b", Description="Short Broadcast")]
		ShortBroadcast = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("97829591-8b05-42fb-9b0c-d55e29bcc0b1", Description="Broadcast")]
		Broadcast = 5,
	}
}