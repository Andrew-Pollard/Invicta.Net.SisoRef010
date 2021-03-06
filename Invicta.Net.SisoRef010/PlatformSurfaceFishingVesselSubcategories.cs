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
	
	[Invicta.Net.SisoRef010.Attributes.SisoEnumerationAttribute(447, "Platform-Surface Fishing Vessel Subcategories", 8)]
	public enum PlatformSurfaceFishingVesselSubcategories : byte {
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("a42d11af-2c25-4a9a-8425-a7930bb68fac", Description="Small Fishing Vessel (up to 26ft/7.9m)")]
		SmallFishingVesselUpTo26FtOr7_9M = 1,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("5fe23044-5c33-4b08-add9-6134e4be6912", Description="Medium Fishing Vessel (up to 65ft/19.8m)")]
		MediumFishingVesselUpTo65FtOr19_8M = 2,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("0d7f312f-a6c8-407e-853e-c6b7f5831acb", Description="Large Fishing Vessel (greater than 65ft/19.8m)")]
		LargeFishingVesselGreaterThan65FtOr19_8M = 3,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("ac37930a-35ab-4493-a114-5e960b94219f", Description="Fish Processing Vessel")]
		FishProcessingVessel = 4,
		[Invicta.Net.SisoRef010.Attributes.SisoEnumerantAttribute("312666a6-e64a-4047-873d-9953b69f6b82", Description="Masted Fishing Vessel")]
		MastedFishingVessel = 5,
	}
}
