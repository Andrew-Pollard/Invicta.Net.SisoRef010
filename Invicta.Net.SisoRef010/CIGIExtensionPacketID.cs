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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(780, "CIGI Extension Packet ID", 16)]
	public enum CIGIExtensionPacketID : ushort {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("72a7fd39-2a9c-4285-9d08-e08165b6ad6c", Description="Image Capture Request packet ID")]
		ImageCaptureRequestPacketID = 4096,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a6a73dbc-c5d1-403e-b8a0-8e9f7ee4ca93", Description="Image Capture Response packet ID")]
		ImageCaptureResponsePacketID = 4097,
	}
}
